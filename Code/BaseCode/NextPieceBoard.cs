using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadris {
  public class NextPieceBoard {
    public GridCellInfo[,] Grid { get; private set; }
    public Piece NextPiece { get; set; }

    public NextPieceBoard() {
      Grid = new GridCellInfo[4, 4];
      for (int i = 0; i < Grid.GetLength(0); i++) {
        for (int j = 0; j < Grid.GetLength(1); j++) {
          Grid[i, j] = new GridCellInfo();
        }
      }
    }

    public void Update() {
      DisplayNextPiece();
    }
    private void DisplayNextPiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfo cellInfo = Grid[r, c];
          if (cellInfo.State == CellState.OCCUPIED_NEXT_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < NextPiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < NextPiece.Layout.GetLength(1); c++) {
          if (NextPiece.Layout[r, c]) {
            GridCellInfo cellInfo = GetCellInfo(r, c);
            cellInfo?.SetToNextPiece(NextPiece);
          }
        }
      }
    }
    public GridCellInfo GetCellInfo(int row, int col) {
      if (row < 0 || row >= Grid.GetLength(0) || col < 0 || col >= Grid.GetLength(1))
        return null;
      else
        return Grid[row, col];
    }


  }
}
