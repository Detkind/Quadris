#pragma warning disable 1591
namespace Quadris {
  public enum CellState {
    EMPTY,
    OCCUPIED_PREVIOUSLY,
    OCCUPIED_ACTIVE_PIECE,
    OCCUPIED_NEXT_PIECE,
    COLLISION,
    OCCUPIED_SHADOW_PIECE,
    SHADOW,
	OCCUPIED_HELD_PIECE
  }

  public enum MoveDir {
    LEFT,
    RIGHT,
    DOWN
  }

  public class GridCellInfo {
    public PieceColor Color { get; set; }
    public CellState State { get; set; }

    public GridCellInfo() {
      Reset();
    }

    public void Reset() {
      Color = PieceColor.NONE;
      State = CellState.EMPTY;
    }

    public void SetToActivePiece(Piece activePiece) {
      State = CellState.OCCUPIED_ACTIVE_PIECE;
      Color = activePiece.Color;
    }

    public void SetToShadowPiece(Piece shadowPiece) {
      State = CellState.OCCUPIED_SHADOW_PIECE;
      Color = shadowPiece.Color; 
    }

    public void SetToNextPiece(Piece nextPiece) {
      State = CellState.OCCUPIED_NEXT_PIECE;
      Color = nextPiece.Color;
    }

    public void SetToHeldPiece(Piece heldPiece) {
      State = CellState.OCCUPIED_HELD_PIECE;
      Color = heldPiece.Color; 
    }
  }

  public class Board
  {
    public GridCellInfo[,] Grid { get; private set; }
    public Piece ActivePiece { get; set; }
    public Piece ShadowPiece { get; set; }

    public int Score = 0;
    public int ClearedRows = 0;
    public int Level = 1;
    public int LevelSpeed = 500;
    public bool GameOver = false;
    public bool Paused = false;

    public Board() {
      Grid = new GridCellInfo[24, 10];
      for (int i = 0; i < Grid.GetLength(0); i++) {
        for (int j = 0; j < Grid.GetLength(1); j++) {
          Grid[i, j] = new GridCellInfo();
        }
      }
    }

    /// <summary>
    /// This method updates the grid and moves the active piece down
    /// </summary>
    /// 
    public bool Update() {
      bool settled = false;
      if (ActivePieceCanMove(MoveDir.DOWN)) {
        UpdateShadow();
        ActivePiece.MoveDown();
        RefreshGridWithActivePiece();
      }
      else {
        GameOver = IsGameOver();
        if (GameOver) {
            return true;
        }
        settled = true;
        SettlePiece();
        CheckForLine();
      }
      return settled;
    }

    public bool IsGameOver() {
      for (int row = 0; row < ActivePiece.Layout.GetLength(0); row++) {
        for (int col = 0; col < ActivePiece.Layout.GetLength(1); col++) {
          if (ActivePiece.Layout[row, col] && (ActivePiece.GridRow + row) < 4) {
            return true;
          }
        }
      }
      return false;
    }

    public void UpdateShadow() {
      ShadowPiece.GridRow = ActivePiece.GridRow;
      while (ShadowPieceCanMove()) {
        ShadowPiece.MoveDown();
        RefreshGridWithShadowPiece();
      }
    }

    private void RefreshGridWithShadowPiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfo cellInfo = Grid[r, c];
          if (cellInfo.State == CellState.OCCUPIED_SHADOW_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < ShadowPiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < ShadowPiece.Layout.GetLength(1); c++) {
          if (ShadowPiece.Layout[r, c]) {
            GridCellInfo cellInfo = GetCellInfo(r + ShadowPiece.GridRow, c + ShadowPiece.GridCol);
            cellInfo?.SetToShadowPiece(ShadowPiece);
          }
        }
      }
    }

    private void RefreshGridWithActivePiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfo cellInfo = Grid[r, c];
          if (cellInfo.State == CellState.OCCUPIED_ACTIVE_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
          if (ActivePiece.Layout[r, c]) {
            GridCellInfo cellInfo = GetCellInfo(r + ActivePiece.GridRow, c + ActivePiece.GridCol);
            cellInfo?.SetToActivePiece(ActivePiece);
          }
        }
      }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="row">the row</param>
    /// <param name="col">the column</param>
    /// <returns>A GridCellInfo object</returns>
    public GridCellInfo GetCellInfo(int row, int col) {
      if (row < 0 || row >= Grid.GetLength(0) || col < 0 || col >= Grid.GetLength(1))
        return null;
      else
        return Grid[row, col];
    }

    public void MoveActivePieceLeft() {
      if (ActivePieceCanMove(MoveDir.LEFT)) {
        ActivePiece.MoveLeft();
        ShadowPiece.MoveLeft();
        UpdateShadow();
        RefreshGridWithActivePiece();
      }
    }

    public void MoveActivePieceRight() {
      if (ActivePieceCanMove(MoveDir.RIGHT)) {
        ActivePiece.MoveRight();
        ShadowPiece.MoveRight();
        UpdateShadow();
        RefreshGridWithActivePiece();
      }
    }

    public void RotateActivePieceRight() {
      ActivePiece.RotateRight();
      ShadowPiece.RotateRight();
      if (CheckForOutOfBounds()) {
        ActivePiece.RotateLeft();
        ShadowPiece.RotateLeft();
      }
      UpdateShadow();
      RefreshGridWithActivePiece();
    }

    public void RotateActivePieceLeft() {
      ActivePiece.RotateLeft();
      ShadowPiece.RotateLeft();
      if (CheckForOutOfBounds()) {
        ActivePiece.RotateRight();
        ShadowPiece.RotateRight();
      }
      UpdateShadow();
      RefreshGridWithActivePiece();
    }

    public bool ShadowPieceCanMove() {
      bool canMove = true;
      for (int c = 0; c < ShadowPiece.Layout.GetLength(1); c++) {
        int lastRow = -1;
        for (int r = 0; r < ShadowPiece.Layout.GetLength(0); r++) {
          if (ShadowPiece.Layout[r, c]) {
            lastRow = r;
          }
        }
        if (lastRow == -1) {
          continue;
        }
        GridCellInfo cellInfo = GetCellInfo(ShadowPiece.GridRow + lastRow + 1, ShadowPiece.GridCol + c);
        if (cellInfo == null || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
          canMove = false;
          break;
        }
      }
      return canMove;
    }
    public bool ActivePieceCanMove(MoveDir moveDir) {
      bool canMove = true;
      switch (moveDir) {
        case MoveDir.DOWN:
          for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
            int lastRow = -1;
            for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
              if (ActivePiece.Layout[r, c]) {
                lastRow = r;
              }
            }
            if (lastRow == -1) {
              continue;
            }
            GridCellInfo cellInfo = GetCellInfo(ActivePiece.GridRow + lastRow + 1, ActivePiece.GridCol + c);
            if (cellInfo == null || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
              canMove = false;
              break;
            }
          }
          break;

        case MoveDir.LEFT:
          for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
            int firstCol = -1;
            for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
              if (ActivePiece.Layout[r, c]) {
                firstCol = c;
                break;
              }
            }
            if (firstCol == -1) {
              continue;
            }
            GridCellInfo cellInfo = GetCellInfo(ActivePiece.GridRow + r, ActivePiece.GridCol + firstCol - 1);
            if (cellInfo == null || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
              canMove = false;
              break;
            }
          }
          break;

        case MoveDir.RIGHT:
          for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
            int lastCol = -1;
            for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
              if (ActivePiece.Layout[r, c]) {
                lastCol = c;
              }
            }
            if (lastCol == -1) {
              continue;
            }
            GridCellInfo cellInfo = GetCellInfo(ActivePiece.GridRow + r, ActivePiece.GridCol + lastCol + 1);
            if (cellInfo == null || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
              canMove = false;
              break;
            }
          }
          break;
      }
      return canMove;
    }

    private bool CheckForOutOfBounds() {
      for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
          if (ActivePiece.Layout[r, c]) {
            GridCellInfo cellInfo = GetCellInfo(r + ActivePiece.GridRow, c + ActivePiece.GridCol);
            if (cellInfo == null || cellInfo.State == CellState.OCCUPIED_PREVIOUSLY) {
              return true;
            }
          }
        }
      }
      return false;
    }

    public void SettlePiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfo cellInfo = Grid[r, c];
          if (cellInfo.State == CellState.OCCUPIED_ACTIVE_PIECE) {
            cellInfo.State = CellState.OCCUPIED_PREVIOUSLY;
          }
        }
      }
    }

    public void CheckForLine() {
      int fullRows = 0;
      for (int curRow = 0; curRow < Grid.GetLength(0); curRow++) {
        bool allFilled = true;
        for (int col = 0; col < Grid.GetLength(1); col++) {
          if (GetCellInfo(curRow, col)?.State == CellState.EMPTY) {
            allFilled = false;
            break;
          }
        }
        if (allFilled) {
          fullRows++;
          for (int col = 0; col < Grid.GetLength(1); col++) {
            for (int dropRow = curRow; dropRow > 0; dropRow--) {
              Grid[dropRow, col] = Grid[dropRow - 1, col];
            }
            Grid[0, col] = new GridCellInfo();
          }
          curRow--;
        }
      }
      UpdateScore(fullRows);
    }

    private void UpdateScore(int fullRows) {
      ClearedRows += fullRows;
      if (fullRows > 0) {
        AddScore(fullRows);
      }
      LvlUP();
    }

    private void AddScore(int fullrows)
    {
      switch (fullrows)
      {
        case 1:
          Score += 40 * Level;
          break;
        case 2:
          Score += 100 * Level;
          break;
        case 3:
          Score += 1200 * Level;
          break;
        default:
          Score += 1200 * Level;
          break;
      }
    }

    public void ChangePause() {
      if(Paused) {
        Paused = false;
      }
      else {
        Paused = true;
      }
    }

    public void LvlUP() {
      if ((Level * 10) < ClearedRows && Level < 10) {
        Level++;
        LevelSpeed -= 40;
      }
    }
  }
}
