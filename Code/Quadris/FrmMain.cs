using Quadris.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Quadris {
  public partial class FrmMain : Form {
	private const int BOARD_COLS = 10;  // number of columns for the main board
	private const int BOARD_ROWS = 20;  // number of rows for the main board

	private const int CELL_WIDTH = 20; // width of each individual cell
	private const int CELL_HEIGHT = 20; // height of each individual cell

    private const int NEXTPIECE_COLS = 4; // number of columns for the next piece board
    private const int NEXTPIECE_ROWS = 4; // number of rows for the next piece board

    private Label[,] gridControls; // main board grid which is displayed
    private Label[,] nextPieceGridControls; // next piece grid which is displayed
	private Board board; // main board
    private NextPieceBoard nextPieceBoard; // next piece board

    private SoundPlayer sndPlayer;

	private static readonly Dictionary<PieceColor, Image> pieceColorToImgMap = new Dictionary<PieceColor, Image> {
	  {PieceColor.BLUE, Resources.cell_blue},
	  {PieceColor.CYAN, Resources.cell_cyan},
	  {PieceColor.GREEN, Resources.cell_green},
	  {PieceColor.ORANGE, Resources.cell_orange},
	  {PieceColor.PURPLE, Resources.cell_purple},
	  {PieceColor.RED, Resources.cell_red},
	  {PieceColor.YELLOW, Resources.cell_yellow},
      {PieceColor.SHADOW_BLUE, Resources.cell_blue_shadow},
	  {PieceColor.SHADOW_CYAN, Resources.cell_cyan_shadow},
	  {PieceColor.SHADOW_GREEN, Resources.cell_green_shadow},
	  {PieceColor.SHADOW_ORANGE, Resources.cell_orange_shadow},
	  {PieceColor.SHADOW_PURPLE, Resources.cell_purple_shadow},
	  {PieceColor.SHADOW_RED, Resources.cell_red_shadow},
	  {PieceColor.SHADOW_YELLOW, Resources.cell_yellow_shadow}
	};

	public FrmMain() {
	  InitializeComponent();
	}

    private void FrmMain_Load(object sender, EventArgs e) {
      // instantiate boards
      board = new Board();
      nextPieceBoard = new NextPieceBoard();
      // get first piece and set it as main board's active piece
      Piece piece = Piece.GetRandPiece();
      board.ActivePiece = piece;
      board.ShadowPiece = Piece.MakeShadowPieceCopy(piece);
      // get next piece and set it as the next piece board's next piece
      Piece nextPiece = Piece.GetRandPiece();
      nextPieceBoard.NextPiece = nextPiece;
      // create main grid and next piece grid
      CreateGrid();
      CreateNextPieceGrid();
      //sndPlayer = new SoundPlayer(Resources.bg_music);
      //sndPlayer.PlayLooping();
    }

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

    private void CreateNextPieceGrid() {
      panel1.Width = CELL_WIDTH * NEXTPIECE_COLS;
      panel1.Height = CELL_HEIGHT * NEXTPIECE_ROWS;
      nextPieceGridControls = new Label[NEXTPIECE_ROWS, NEXTPIECE_COLS];
      panel1.Controls.Clear();
      for (int col = 0; col < NEXTPIECE_COLS; col++) {
        for (int row = 0; row < NEXTPIECE_ROWS; row++) {
          Label lblCell = MakeGridCell(row, col);
          panel1.Controls.Add(lblCell);
          nextPieceGridControls[row, col] = lblCell;
        }
      }
    }
    
    private void UpdateNextPieceGrid() {
      for (int col = 0; col < NEXTPIECE_COLS; col++) {
        for (int row = 0; row < NEXTPIECE_ROWS; row++) {
          GridCellInfo cellInfo = nextPieceBoard.Grid[row, col];
          if (cellInfo.State == CellState.OCCUPIED_NEXT_PIECE) {
            nextPieceGridControls[row, col].Image = pieceColorToImgMap[cellInfo.Color];
          }
          else {
            nextPieceGridControls[row, col].Image = null;
          }
        }
      }
    }

    private void UpdateGrid() {
      for (int col = 0; col < BOARD_COLS; col++) {
        for (int row = 0; row < BOARD_ROWS; row++) {
          GridCellInfo cellInfo = board.Grid[row + 4, col];
          if (cellInfo.State == CellState.OCCUPIED_ACTIVE_PIECE || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY || cellInfo.State == CellState.OCCUPIED_SHADOW_PIECE) {
            gridControls[row, col].Image = pieceColorToImgMap[cellInfo.Color];
          }
          else {
            gridControls[row, col].Image = null;
          }
        }
      }
    }

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

    private void UpdateScore() {
      lblScoreNum.Text = board.Score.ToString();
    }

    private void UpdateLevel() {
      lblLevelNum.Text = board.Level.ToString();
    }

    private void tmrFps_Tick(object sender, EventArgs e)
    {

        if (!board.Paused)
        {
            tmrFps.Interval = board.LevelSpeed;
            // update method in board returns a boolean value on whether a piece has been settled or not
            bool settled = board.Update();

            if (board.GameOver)
            {
                tmrFps.Stop();
                MessageBox.Show("Game Over");
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.Show();
            }

            nextPieceBoard.Update();

            // set active piece to next piece and create new shadow piece and new next piece once a piece has been settled
            if (settled)
            {
                board.ActivePiece = nextPieceBoard.NextPiece;
                board.ShadowPiece = Piece.MakeShadowPieceCopy(nextPieceBoard.NextPiece);
                nextPieceBoard.NextPiece = Piece.GetRandPiece();
            }
            UpdateGrid();
            UpdateNextPieceGrid();
            UpdateScore();
            UpdateLevel();
        }
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e) {
	  switch (e.KeyCode) {
        case Keys.X:
          if (!board.Paused)
          {
            board.RotateActivePieceRight();
            UpdateGrid();
          }
          break;
        case Keys.Z:
            if (!board.Paused)
            {
                board.RotateActivePieceLeft();
                UpdateGrid();
            }
          break;
        case Keys.Right:
            if (!board.Paused)
            {
                board.MoveActivePieceRight();
                UpdateGrid();
            }
          break;
        case Keys.Left:
          if (!board.Paused)
          {
            board.MoveActivePieceLeft();
            UpdateGrid();
          }
          break;
		case Keys.Down:
		  tmrFps.Interval = 50;
          break;
        case Keys.Tab:
          board.ChangePause();
          break;
            }
    }

    private void panBoard_Paint(object sender, PaintEventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e) {

    }

    private void lblNextPiece_Click(object sender, EventArgs e) {

    }

    private void label1_Click_1(object sender, EventArgs e) {

    }

    private void FrmMain_KeyUp(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.Down:
          tmrFps.Interval = 200;
          break;
      }
    }
  }
}
