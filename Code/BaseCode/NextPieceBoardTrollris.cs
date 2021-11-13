#pragma warning disable 1591
namespace Quadris {
  public class NextPieceBoardTrollris {
    public GridCellInfoTrollris[,] Grid { get; private set; }
    public PieceTrollris NextPiece { get; set; }

    public NextPieceBoardTrollris() {
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
          if (cellInfo.State == CellStateTrollris.OCCUPIED_NEXT_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < NextPiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < NextPiece.Layout.GetLength(1); c++) {
          if (NextPiece.Layout[r, c]) {
            GridCellInfoTrollris cellInfo = GetCellInfo(r, c);
            cellInfo?.SetToNextPiece(NextPiece);
          }
        }
      }
    }

    public GridCellInfoTrollris GetCellInfo(int row, int col) {
      if (row < 0 || row >= Grid.GetLength(0) || col < 0 || col >= Grid.GetLength(1))
        return null;
      else
        return Grid[row, col];
    }
  }
}
