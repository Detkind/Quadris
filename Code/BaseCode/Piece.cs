#pragma warning disable 1591
using System;
using System.Linq;
using System.Threading;

namespace Quadris {
  public enum PieceType {
    L,
    J,
    Z,
    S,
    I,
    T,
    O,
  }

  public enum PieceColor {
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

  public class Piece {
    private const int LAYOUT_ROWS = 4;
    private const int LAYOUT_COLS = 4;

    private static readonly Random rand;

    public bool[,] Layout { get; private set; }
    public int GridRow { get; set; }
    public int GridCol { get; set; }
    public PieceType Type { get; private set; }
    public PieceColor Color { get; private set; }

    static Piece() {
      rand = new Random();
    }

    public Piece(string strLayout, PieceColor color, PieceType type) {
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
    public static Piece GetRandPiece() {
      int pieceNum = rand.Next(Enum.GetValues(typeof(PieceType)).Length);
      return MakePiece((PieceType)pieceNum);
    }

    public static Piece MakePiece(PieceType type) {
      Piece piece = null;
      switch (type) {
        case PieceType.L: piece = new Piece("0000010001000110", PieceColor.ORANGE, PieceType.L); break;
        case PieceType.J: piece = new Piece("0000001000100110", PieceColor.BLUE, PieceType.J); break;
        case PieceType.Z: piece = new Piece("0000011000110000", PieceColor.RED, PieceType.Z); break;
        case PieceType.S: piece = new Piece("0000011011000000", PieceColor.GREEN, PieceType.S); break;
        case PieceType.I: piece = new Piece("0010001000100010", PieceColor.CYAN, PieceType.I); break;
        case PieceType.T: piece = new Piece("0000001001110000", PieceColor.PURPLE, PieceType.T); break;
        case PieceType.O: piece = new Piece("0000011001100000", PieceColor.YELLOW, PieceType.O); break;
      }
      return piece;
    }

    public static Piece MakeShadowPieceCopy(Piece piece) {
      Piece shadowPiece = null;
      switch (piece.Type) {
        case PieceType.L: shadowPiece = new Piece("0000010001000110", PieceColor.SHADOW_ORANGE, PieceType.L); break;
        case PieceType.J: shadowPiece = new Piece("0000001000100110", PieceColor.SHADOW_BLUE, PieceType.J); break;
        case PieceType.Z: shadowPiece = new Piece("0000011000110000", PieceColor.SHADOW_RED, PieceType.Z); break;
        case PieceType.S: shadowPiece = new Piece("0000011011000000", PieceColor.SHADOW_GREEN, PieceType.S); break;
        case PieceType.I: shadowPiece = new Piece("0010001000100010", PieceColor.SHADOW_CYAN, PieceType.I); break;
        case PieceType.T: shadowPiece = new Piece("0000001001110000", PieceColor.SHADOW_PURPLE, PieceType.T); break;
        case PieceType.O: shadowPiece = new Piece("0000011001100000", PieceColor.SHADOW_YELLOW, PieceType.O); break;
      }
      return shadowPiece;
    }

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
