using Quadris.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Quadris {
  public partial class FrmMain : Form {
	private const int BOARD_COLS = 10;  //Sets the number of columns 
	private const int BOARD_ROWS = 20;  //Sets the number of Rows

	private const int CELL_WIDTH = 20; //Creates the width of the entire grid
	private const int CELL_HEIGHT = 20; // Creates the height of the entire Grid

    private const int NEXTPIECE_COLS = 4;
    private const int NEXTPIECE_ROWS = 4;

	private Label[,] gridControls; //Creats the grid
    private Label[,] nextPieceGridControls;
	private Board board; //Creates the board
    private Board nextPieceBoard;

    private SoundPlayer sndPlayer;

	private static readonly Dictionary<PieceColor, Image> pieceColorToImgMap = new Dictionary<PieceColor, Image> {
	  {PieceColor.BLUE, Resources.cell_blue},
	  {PieceColor.CYAN, Resources.cell_cyan},
	  {PieceColor.GREEN, Resources.cell_green},
	  {PieceColor.MAGENTA, Resources.cell_magenta},
	  {PieceColor.ORANGE, Resources.cell_orange},
	  {PieceColor.PURPLE, Resources.cell_purple},
	  {PieceColor.RED, Resources.cell_red},
	  {PieceColor.WHITE, Resources.cell_white},
	  {PieceColor.YELLOW, Resources.cell_yellow},
	  {PieceColor.FIRE, Resources.cell_fire},
	  {PieceColor.ICE, Resources.cell_ice},
	  {PieceColor.GROUND, Resources.cell_ground},
	  {PieceColor.DARK, Resources.cell_dark},
	};

	public FrmMain() {
	  InitializeComponent();
	}

    private void FrmMain_Load(object sender, EventArgs e) {
      board = new Board();
      nextPieceBoard = new Board();
      Piece piece = Piece.GetRandPiece();
      board.ActivePiece = piece;
      Piece nextPiece = Piece.GetRandPiece();
      board.nextPiece = nextPiece;
      CreateGrid();
      CreateNextPieceGrid();
      sndPlayer = new SoundPlayer(Resources.bg_music);
      sndPlayer.PlayLooping();
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
          if (cellInfo.State == CellState.OCCUPIED_ACTIVE_PIECE || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
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
          if (cellInfo.State == CellState.OCCUPIED_ACTIVE_PIECE || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
            gridControls[row, col].Image = pieceColorToImgMap[cellInfo.Color];
          }
          else {
            gridControls[row, col].Image = null;
          }
        }
      }
      UpdateNextPieceGrid();
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
    
    private void tmrFps_Tick(object sender, EventArgs e) {
      board.Update();
      UpdateGrid();
    }

    private void FrmMain_KeyDown(object sender, KeyEventArgs e) {
      switch (e.KeyCode) {
        case Keys.X:
          board.RotateActivePieceRight();
          break;
        case Keys.Z:
          board.RotateActivePieceLeft();
          break;
        case Keys.Right:
          board.MoveActivePieceRight();
          break;
        case Keys.Left:
          board.MoveActivePieceLeft();
          break;
      }
    }

        private void panBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
