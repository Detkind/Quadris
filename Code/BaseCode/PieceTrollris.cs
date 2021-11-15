#pragma warning disable 1591
using System;
using System.Linq;
using System.Threading;

namespace Quadris {
  public enum PieceTypeTrollris {
    L,
    J,
    Z,
    S,
    I,
    T,
    O,
  }

  public enum PieceColorTrollris {
    NONE,
    BLUE,
    RED,
    CYAN,
    GREEN,
    ORANGE,
    PURPLE,
    YELLOW,
    SHADOW_BLUE,
    SHADOW_RED,
    SHADOW_CYAN,
    SHADOW_GREEN,
    SHADOW_ORANGE,
    SHADOW_PURPLE,
    SHADOW_YELLOW
  }

  public class PieceTrollris {
    private const int LAYOUT_ROWS = 4;
    private const int LAYOUT_COLS = 4;

    private static readonly Random rand;

    public bool[,] Layout { get; private set; }
    public int GridRow { get; set; }
    public int GridCol { get; set; }
    public static int StartPos { get; set; }
    public PieceTypeTrollris Type { get; private set; }
    public PieceColorTrollris Color { get; private set; }

    static PieceTrollris() {
      rand = new Random();
    }

    public PieceTrollris(string strLayout, PieceColorTrollris color, PieceTypeTrollris type) {
      GridRow = 0;
      GridCol = 3;
      Color = color;
      Type = type;
      Layout = new bool[LAYOUT_ROWS, LAYOUT_COLS];
      for (int c = 0; c < LAYOUT_COLS; c++) {
        for (int r = 0; r < LAYOUT_ROWS; r++) {
          Layout[r, c] = (strLayout[r * LAYOUT_COLS + c] == '1');
        }
      }
    }

    /// <summary>
    /// The GetRandPiece class takes the pieces and returns one of them at random. 
    /// </summary>
    /// <returns></returns>
    public static PieceTrollris GetRandPiece() {
      int pieceNum = rand.Next(Enum.GetValues(typeof(PieceTypeTrollris)).Length);
      return MakePiece((PieceTypeTrollris)pieceNum);
    }

    //Function that returns a random piece with a random starting position
    public static PieceTrollris MakePiece(PieceTypeTrollris type) {
      PieceTrollris piece = null;
      switch (type) {
        case PieceTypeTrollris.L: piece = new PieceTrollris("0000010001000110", PieceColorTrollris.ORANGE, PieceTypeTrollris.L); break;
        case PieceTypeTrollris.J: piece = new PieceTrollris("0000001000100110", PieceColorTrollris.BLUE, PieceTypeTrollris.J); break;
        case PieceTypeTrollris.Z: piece = new PieceTrollris("0000011000110000", PieceColorTrollris.RED, PieceTypeTrollris.Z); break;
        case PieceTypeTrollris.S: piece = new PieceTrollris("0000011011000000", PieceColorTrollris.GREEN, PieceTypeTrollris.S); ; break;
        case PieceTypeTrollris.I: piece = new PieceTrollris("0010001000100010", PieceColorTrollris.CYAN, PieceTypeTrollris.I); break;
        case PieceTypeTrollris.T: piece = new PieceTrollris("0000001001110000", PieceColorTrollris.PURPLE, PieceTypeTrollris.T); break;
        case PieceTypeTrollris.O: piece = new PieceTrollris("0000011001100000", PieceColorTrollris.YELLOW, PieceTypeTrollris.O); break;
      }
      StartPos = rand.Next(6);
      piece.GridCol = StartPos;
      return piece;
    }

    //Returns a copy of the given piece
    public static PieceTrollris MakeShadowPieceCopy(PieceTrollris piece) {
      PieceTrollris shadowPiece = null;
      switch (piece.Type) {
        case PieceTypeTrollris.L: shadowPiece = new PieceTrollris("0000010001000110", PieceColorTrollris.SHADOW_ORANGE, PieceTypeTrollris.L); break;
        case PieceTypeTrollris.J: shadowPiece = new PieceTrollris("0000001000100110", PieceColorTrollris.SHADOW_BLUE, PieceTypeTrollris.J); break;
        case PieceTypeTrollris.Z: shadowPiece = new PieceTrollris("0000011000110000", PieceColorTrollris.SHADOW_RED, PieceTypeTrollris.Z); break;
        case PieceTypeTrollris.S: shadowPiece = new PieceTrollris("0000011011000000", PieceColorTrollris.SHADOW_GREEN, PieceTypeTrollris.S); ; break;
        case PieceTypeTrollris.I: shadowPiece = new PieceTrollris("0010001000100010", PieceColorTrollris.SHADOW_CYAN, PieceTypeTrollris.I); break;
        case PieceTypeTrollris.T: shadowPiece = new PieceTrollris("0000001001110000", PieceColorTrollris.SHADOW_PURPLE, PieceTypeTrollris.T); break;
        case PieceTypeTrollris.O: shadowPiece = new PieceTrollris("0000011001100000", PieceColorTrollris.SHADOW_YELLOW, PieceTypeTrollris.O); break;
      }
      shadowPiece.GridCol = StartPos;
      return shadowPiece;
    }

    //Function that rotates the active piece right
    public void RotateRight() {
      bool[] read = Layout.Cast<bool>().ToArray();
      bool[] write = new bool[read.Length];

      write[0] = read[12];
      write[1] = read[8];
      write[2] = read[4];
      write[3] = read[0];
      write[4] = read[13];
      write[5] = read[9];
      write[6] = read[5];
      write[7] = read[1];
      write[8] = read[14];
      write[9] = read[10];
      write[10] = read[6];
      write[11] = read[2];
      write[12] = read[15];
      write[13] = read[11];
      write[14] = read[7];
      write[15] = read[3];

      for (int r = 0; r < Layout.GetLength(0); r++) {
        for (int c = 0; c < Layout.GetLength(1); c++) {
          Layout[r, c] = write[r * Layout.GetLength(1) + c];
        }
      }
    }

    //Function that rotates the active piece left
    public void RotateLeft() {
      bool[] read = Layout.Cast<bool>().ToArray();
      bool[] write = new bool[read.Length];

      write[0] = read[3];
      write[1] = read[7];
      write[2] = read[11];
      write[3] = read[15];
      write[4] = read[2];
      write[5] = read[6];
      write[6] = read[10];
      write[7] = read[14];
      write[8] = read[1];
      write[9] = read[5];
      write[10] = read[9];
      write[11] = read[13];
      write[12] = read[0];
      write[13] = read[4];
      write[14] = read[8];
      write[15] = read[12];

      for (int r = 0; r < Layout.GetLength(0); r++) {
        for (int c = 0; c < Layout.GetLength(1); c++) {
          Layout[r, c] = write[r * Layout.GetLength(1) + c];
        }
      }
    }


    public void MoveDown() {
      GridRow++;
    }

    public void MoveLeft() {
      GridCol--;
    }

    public void MoveRight() {
      GridCol++;
	}
  }
}
