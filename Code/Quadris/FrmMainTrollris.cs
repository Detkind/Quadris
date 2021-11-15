#pragma warning disable 1591
using Quadris.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.IO;

namespace Quadris {
  public partial class FrmMainTrollris : Form {
    private const int BOARD_COLS = 10;  // number of columns for the main board
    private const int BOARD_ROWS = 20;  // number of rows for the main board

    private const int CELL_WIDTH = 20; // width of each individual cell
    private const int CELL_HEIGHT = 20; // height of each individual cell

    private const int NEXTPIECE_COLS = 4; // number of columns for the next piece board
    private const int NEXTPIECE_ROWS = 4; // number of rows for the next piece board

    private const int HELDPIECE_COLS = 4;
    private const int HELDPIECE_ROWS = 4;
    private bool Swapped;

    private Label[,] gridControls; // main board grid which is displayed
    private Label[,] nextPieceGridControls; // next piece grid which is displayed
    private Label[,] heldPieceGridControls;
    private BoardTrollris board; // main board
    private NextPieceBoardTrollris nextPieceBoard; // next piece board
    private HeldPieceBoardTrollris heldPieceBoard;

    private SoundPlayer sndPlayer;
    private SoundPlayer explosionSound = new SoundPlayer(Resources.explosion_meme_sound_effect);
    private bool muted;
    private bool inverted;
    private Random trollRandomizer;
    private int trollBase;

    private static readonly Dictionary<PieceColorTrollris, Image> pieceColorToImgMap = new Dictionary<PieceColorTrollris, Image> {
      {PieceColorTrollris.BLUE, Resources.cell_blue},
      {PieceColorTrollris.CYAN, Resources.cell_cyan},
      {PieceColorTrollris.GREEN, Resources.cell_green},
      {PieceColorTrollris.ORANGE, Resources.cell_orange},
      {PieceColorTrollris.PURPLE, Resources.cell_purple},
      {PieceColorTrollris.RED, Resources.cell_red},
      {PieceColorTrollris.YELLOW, Resources.cell_yellow},
      {PieceColorTrollris.SHADOW_BLUE, Resources.cell_blue_shadow},
      {PieceColorTrollris.SHADOW_CYAN, Resources.cell_cyan_shadow},
      {PieceColorTrollris.SHADOW_GREEN, Resources.cell_green_shadow},
      {PieceColorTrollris.SHADOW_ORANGE, Resources.cell_orange_shadow},
      {PieceColorTrollris.SHADOW_PURPLE, Resources.cell_purple_shadow},
      {PieceColorTrollris.SHADOW_RED, Resources.cell_red_shadow},
      {PieceColorTrollris.SHADOW_YELLOW, Resources.cell_yellow_shadow}
    };

    public FrmMainTrollris() {
      InitializeComponent();
    }

    private void FrmMainTrollris_Load(object sender, EventArgs e) {
      this.Size = new Size(600, 680);
      this.KeyPreview = true;
      // instantiate boards
      Swapped = false;
      board = new BoardTrollris();
      nextPieceBoard = new NextPieceBoardTrollris();
      heldPieceBoard = new HeldPieceBoardTrollris();
      // get first piece and set it as main board's active piece
      PieceTrollris piece = PieceTrollris.GetRandPiece();
      board.ActivePiece = piece;
      board.ShadowPiece = PieceTrollris.MakeShadowPieceCopy(piece);
      // get next piece and set it as the next piece board's next piece
      PieceTrollris nextPiece = PieceTrollris.GetRandPiece();
      nextPieceBoard.NextPiece = nextPiece;
      // create main grid and next piece grid
      CreateGrid();
      CreateNextPieceGrid();
      CreateHeldPieceGrid();

      PickRandomSong();
      sndPlayer.PlayLooping();
      muted = false;
      inverted = false;
      trollRandomizer = new Random();
      trollBase = 50;
    }

    //Function that creates a grid that represents the game board
    private void CreateGrid() {
      panBoard.Width = CELL_WIDTH * BOARD_COLS + 4;
      panBoard.Height = CELL_HEIGHT * BOARD_ROWS + 4;
      gridControls = new Label[BOARD_ROWS, BOARD_COLS];
      panBoard.Controls.Clear();
      for (int col = 0; col < BOARD_COLS; col++) {
        for (int row = 0; row < BOARD_ROWS; row++) {
          Label lblCell = MakeGridCell(row, col);
          panBoard.Controls.Add(lblCell);
          gridControls[row, col] = lblCell;
        }
      }
    }

    //Functon that creates a grid to display the next piece
    private void CreateNextPieceGrid() {
      panelNextPiece.Width = CELL_WIDTH * NEXTPIECE_COLS;
      panelNextPiece.Height = CELL_HEIGHT * NEXTPIECE_ROWS;
      nextPieceGridControls = new Label[NEXTPIECE_ROWS, NEXTPIECE_COLS];
      panelNextPiece.Controls.Clear();
      for (int col = 0; col < NEXTPIECE_COLS; col++) {
        for (int row = 0; row < NEXTPIECE_ROWS; row++) {
          Label lblCell = MakeGridCell(row, col);
          panelNextPiece.Controls.Add(lblCell);
          nextPieceGridControls[row, col] = lblCell;
        }
      }
    }

    //Function that creates a grid to display the held piece
    private void CreateHeldPieceGrid() {
      panel2HeldPiece.Width = CELL_WIDTH * HELDPIECE_COLS;
      panel2HeldPiece.Height = CELL_WIDTH * HELDPIECE_ROWS;
      heldPieceGridControls = new Label[HELDPIECE_ROWS, HELDPIECE_COLS];
      panel2HeldPiece.Controls.Clear();
      for (int col = 0; col < NEXTPIECE_COLS; col++) {
        for (int row = 0; row < NEXTPIECE_ROWS; row++) {
          Label lblCell = MakeGridCell(row, col);
          panel2HeldPiece.Controls.Add(lblCell);
          heldPieceGridControls[row, col] = lblCell;
        }
      }
    }

    //Function that updates the next piece display to display the current next piece
    private void UpdateNextPieceGrid() {
      for (int col = 0; col < NEXTPIECE_COLS; col++) {
        for (int row = 0; row < NEXTPIECE_ROWS; row++) {
          GridCellInfoTrollris cellInfo = nextPieceBoard.Grid[row, col];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_NEXT_PIECE) {
            nextPieceGridControls[row, col].Image = pieceColorToImgMap[cellInfo.Color];
          }
          else {
            nextPieceGridControls[row, col].Image = null;
          }
        }
      }
    }

    //Function that updates the held piece display to display the current held piece
    private void UpdateHeldPieceGrid() {
      for (int col = 0; col < HELDPIECE_COLS; col++) {
        for (int row = 0; row < HELDPIECE_ROWS; row++) {
          GridCellInfoTrollris cellInfo = heldPieceBoard.Grid[row, col];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_HELD_PIECE) {
            heldPieceGridControls[row, col].Image = pieceColorToImgMap[cellInfo.Color];
          }
          else {
            heldPieceGridControls[row, col].Image = null;
          }
        }
      }
    }

    //Function that updates the main game board
    private void UpdateGrid() {
      for (int col = 0; col < BOARD_COLS; col++) {
        for (int row = 0; row < BOARD_ROWS; row++) {
          GridCellInfoTrollris cellInfo = board.Grid[row + 4, col];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_ACTIVE_PIECE || cellInfo.State == CellStateTrollris.OCCUPIED_PREVIOUSLY || cellInfo.State == CellStateTrollris.OCCUPIED_SHADOW_PIECE) {
            gridControls[row, col].Image = pieceColorToImgMap[cellInfo.Color];
          }
          else {
            gridControls[row, col].Image = null;
          }
        }
      }
    }

    //Function that returns a label that represents the grid cell at the given row and col on the game board
    private Label MakeGridCell(int row, int col) {
      return new Label() {
        Text = "",
        Width = CELL_WIDTH,
        Height = CELL_HEIGHT,
        FlatStyle = FlatStyle.Flat,
        Top = row * CELL_HEIGHT,
        Left = col * CELL_WIDTH
      };
    }

    //Function that updates the score display
    private void UpdateScore() {
      lblScoreNum.Text = board.Score.ToString();
    }

    //Function that updates the level display
    private void UpdateLevel() {
      lblLevelNum.Text = board.Level.ToString();
    }

    //Function that get a new active and next piece
    private void GetNewActiveandNextPiece() {
      board.ActivePiece = nextPieceBoard.NextPiece;
      board.ShadowPiece = PieceTrollris.MakeShadowPieceCopy(nextPieceBoard.NextPiece);
      nextPieceBoard.NextPiece = PieceTrollris.GetRandPiece();
      UpdateGrid();
    }

    private void PickRandomSong() {
      Random random = new Random();
      int songNum = random.Next(4);
      if (songNum == 0) {
        sndPlayer = new SoundPlayer(Resources.National_Anthem_of_USSR);
      }
      if (songNum == 1) {
        sndPlayer = new SoundPlayer(Resources.Never_Gonna_Give_You_Up_Voice_Crack_HD_Version);
      }
      if (songNum == 2) {
        sndPlayer = new SoundPlayer(Resources.shooting_star_meme);
      }
      if (songNum == 3) {
        sndPlayer = new SoundPlayer(Resources.Smash_Mouth___All_Star);
      }
    }

    //function that constantly updates the board while checking for events
    private void tmrFps_Tick(object sender, EventArgs e) {
      if (muted) {
        PickRandomSong();
        sndPlayer.PlayLooping();
        muted = false;
      }
      if (!board.Paused) {
        tmrFps.Interval = board.LevelSpeed;
        // update method in board returns a boolean value on whether a piece has been settled or not
        bool settled = board.Update();
        if (board.Line) {
          sndPlayer.Stop();
          muted = true;
          explosionSound.PlaySync();
        }

        if (board.GameOver) {
          sndPlayer.Stop();
          tmrFps.Stop();
          updateLeaderboard();
          String message = "Your score is " + board.Score.ToString() + ". Would you like to restart?";
          DialogResult result = MessageBox.Show(message, "Game Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == DialogResult.No) {
            this.Close();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
          }
          else if (result == DialogResult.Yes) {
            this.Close();
            FrmMainTrollris newTrollrisGame = new FrmMainTrollris();
            newTrollrisGame.Show();
          }
        }
        if (heldPieceBoard.HeldPiece != null) {
          UpdateHeldPieceGrid();
        }
        nextPieceBoard.Update();

        // set active piece to next piece and create new shadow piece and new next piece once a piece has been settled
        if (settled) {
          Swapped = false;
          GetNewActiveandNextPiece();
          int startPos = trollRandomizer.Next(6);
          board.ActivePiece.GridCol = startPos;
          board.ShadowPiece.GridCol = startPos;
        }

        // check to see if a troll will occur and enact that troll
        if(trollRandomizer.Next(trollBase/board.Level) == 1)
        {
            triggerTroll(getTroll());
        }

        UpdateGrid();
        UpdateNextPieceGrid();
        UpdateScore();
        UpdateLevel();
      }
    }

    //Function that handles key inputs
    private void FrmMain_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.X:
          if (!board.Paused) {
            board.RotateActivePieceRight();
            UpdateGrid();
          }
          break;

        case Keys.Z:
          if (!board.Paused) {
            board.RotateActivePieceLeft();
            UpdateGrid();
          }
          break;

        case Keys.Right:
          if (!board.Paused) {
            if (!inverted)
            {
              board.MoveActivePieceRight();
            }
            else
            {
              board.MoveActivePieceLeft();
            }
            UpdateGrid();
          }
          break;

        case Keys.Left:
          if (!board.Paused) {
            if (!inverted)
            {
              board.MoveActivePieceLeft();
            }
            else
            {
              board.MoveActivePieceRight();
            }
            UpdateGrid();
          }
          break;

        case Keys.Down:
          tmrFps.Interval = 50;
          break;

        case Keys.P:
          board.ChangePause();
          if (board.Paused) {
            if (!muted) {
              sndPlayer.Stop();
            }
          }
          else if (!board.Paused) {
            if (!muted) {
              sndPlayer.PlayLooping();
            }
          }
          break;

        case Keys.C:
          if (!board.Paused) {
            if (!Swapped) {
              if (heldPieceBoard.HeldPiece != null) {
                PieceTrollris shadow = heldPieceBoard.ShadowPiece;
                PieceTrollris temp = heldPieceBoard.HeldPiece;
                heldPieceBoard.HeldPiece = board.ActivePiece;
                heldPieceBoard.ShadowPiece = board.ShadowPiece;
                board.ActivePiece = temp;
                board.ShadowPiece = shadow;
                board.ActivePiece.GridRow = 0;
              }
              else {
                heldPieceBoard.HeldPiece = board.ActivePiece;
                heldPieceBoard.ShadowPiece = board.ShadowPiece;
                GetNewActiveandNextPiece();
              }
              board.Update();
              UpdateGrid();
              heldPieceBoard.Update();
              UpdateHeldPieceGrid();
              Swapped = true;
            }
          }
          break;

        case Keys.Space:
          if (!board.Paused) {
            board.DropPieceHard();
            if (board.Line) {
              sndPlayer.Stop();
              muted = true;
              explosionSound.PlaySync();
            }
            GetNewActiveandNextPiece();
            board.Update();
            UpdateGrid();
            Swapped = false;
          }
          break;
      }
    }

    //Function that returns a random troll
    private int getTroll()
    {
            int troll = trollRandomizer.Next(1,5);

            return troll;
    }

    //Function that enact the given troll
    private void triggerTroll(int troll)
    {

        switch (troll)
        {
            case 1: inverted = !inverted; break;
            case 2:
                board.DropPieceHard();
                GetNewActiveandNextPiece();
                board.Update();
                UpdateGrid();
                Swapped = false; break;
            case 3:
                if (!Swapped)
                {
                    if (heldPieceBoard.HeldPiece != null)
                    {
                        PieceTrollris shadow = heldPieceBoard.ShadowPiece;
                        PieceTrollris temp = heldPieceBoard.HeldPiece;
                        heldPieceBoard.HeldPiece = board.ActivePiece;
                        heldPieceBoard.ShadowPiece = board.ShadowPiece;
                        board.ActivePiece = temp;
                        board.ShadowPiece = shadow;
                        board.ActivePiece.GridRow = 0;
                    }
                    else
                    {
                        heldPieceBoard.HeldPiece = board.ActivePiece;
                        heldPieceBoard.ShadowPiece = board.ShadowPiece;
                        GetNewActiveandNextPiece();
                    }
                    board.Update();
                    UpdateGrid();
                    heldPieceBoard.Update();
                    UpdateHeldPieceGrid();
                    Swapped = true;
                }
                break;
            case 4:
                if (trollRandomizer.Next(1) == 1)
                {
                    board.RotateActivePieceLeft();
                }
                else
                {
                    board.RotateActivePieceRight();
                }
                UpdateGrid(); break;
        default: break;
        }
    }

    //Function that updates the leaderboard values
    private void updateLeaderboard() {
      try {
        string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        while (dir.Substring(dir.Length - "Quadris".Length) != "Quadris") {
          dir = dir.Remove(dir.Length - 1, 1);
        }

        string path = dir + "\\HighScore.txt";

        if (!File.Exists(path)) {
          // Create a file to write to.
          using (StreamWriter sw = File.CreateText(path)) {
            for (int x = 0; x < 10; x++) {
              sw.WriteLine("0000");
            }
          }
        }

        List<int> scores = new List<int>();
        int score;
        int bumpedScore = board.Score;
        using (StreamReader sr = File.OpenText(path)) {
          for (int x = 0; x < 10; x++) {
            score = int.Parse(sr.ReadLine());
            if (x > 4) {
              if (bumpedScore > score) {
                scores.Add(bumpedScore);
                bumpedScore = score;
              }
              else {
                scores.Add(score);
              }
            }
            else {
              scores.Add(score);
            }
          }
        }

        using (StreamWriter sw = new StreamWriter(path)) {
          for (int x = 0; x < 10; x++) {
            sw.WriteLine(scores[x]);
          }
        }
      }
      catch (Exception e) { }
    }

    //Function that increases the frequency of trolls when the mute button is pressed and also plays earrape song
    private void btnTrollrisUnmuted_Click(object sender, EventArgs e)
    {
        if (trollBase > 10){ trollBase -= 10; }
      sndPlayer = new SoundPlayer(Resources.Smash_Mouth___All_Star_earrape);
      sndPlayer.PlayLooping();
    }

    private void btnTrollrisMuted_Click(object sender, EventArgs e) {
      sndPlayer.PlayLooping();
      btnQuadrisUnmuted.BringToFront();
      muted = false;
      this.Focus();
    }
  }
}
