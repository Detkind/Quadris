#pragma warning disable 1591
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadris {
  public class HeldPieceBoardTrollris {
    public GridCellInfoTrollris[,] Grid { get; private set; }
    public PieceTrollris HeldPiece { get; set; }
    public PieceTrollris ShadowPiece { get; set; }
    public HeldPieceBoardTrollris() {
      Grid = new GridCellInfoTrollris[4, 4];
      for (int i = 0; i < Grid.GetLength(0); i++) {
        for (int j = 0; j < Grid.GetLength(1); j++) {
          Grid[i, j] = new GridCellInfoTrollris();
        }
      }
    }

  
    public void Update() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfoTrollris cellInfo = Grid[r, c];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_HELD_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < HeldPiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < HeldPiece.Layout.GetLength(1); c++) {
          if (HeldPiece.Layout[r, c]) {
            GridCellInfoTrollris cellInfo = GetCellInfo(r, c);
            cellInfo?.SetToHeldPiece(HeldPiece);
          }
        }
      }

      GridCellInfoTrollris GetCellInfo(int row, int col) {
        if (row < 0 || row >= Grid.GetLength(0) || col < 0 || col >= Grid.GetLength(1))
          return null;
        else
          return Grid[row, col];
      }
    }
  } 
}
