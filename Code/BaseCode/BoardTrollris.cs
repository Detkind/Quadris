#pragma warning disable 1591
namespace Quadris {
  public enum CellStateTrollris {
    EMPTY,
    OCCUPIED_PREVIOUSLY,
    OCCUPIED_ACTIVE_PIECE,
    OCCUPIED_NEXT_PIECE,
    COLLISION,
    OCCUPIED_SHADOW_PIECE,
    SHADOW,
	OCCUPIED_HELD_PIECE
  }

  public enum MoveDirTrollris {
    LEFT,
    RIGHT,
    DOWN
  }

  public class GridCellInfoTrollris {
    public PieceColorTrollris Color { get; set; }
    public CellStateTrollris State { get; set; }

    public GridCellInfoTrollris() {
      Reset();
    }

    //Function that empties a grid cell
    public void Reset() {
      Color = PieceColorTrollris.NONE;
      State = CellStateTrollris.EMPTY;
    }

    //Function that turns the given piece into the active piece
    public void SetToActivePiece(PieceTrollris activePiece) {
      State = CellStateTrollris.OCCUPIED_ACTIVE_PIECE;
      Color = activePiece.Color;
    }

    //Function that sets the given piece to the current shadow piece
    public void SetToShadowPiece(PieceTrollris shadowPiece) {
      State = CellStateTrollris.OCCUPIED_SHADOW_PIECE;
      Color = shadowPiece.Color; 
    }

    //Function that sets the next piece to the given piece
    public void SetToNextPiece(PieceTrollris nextPiece) {
      State = CellStateTrollris.OCCUPIED_NEXT_PIECE;
      Color = nextPiece.Color;
    }

    //Function that sets the held piece to the given pice
    public void SetToHeldPiece(PieceTrollris heldPiece) {
      State = CellStateTrollris.OCCUPIED_HELD_PIECE;
      Color = heldPiece.Color; 
    }
  }

  public class BoardTrollris
  {
    public GridCellInfoTrollris[,] Grid { get; private set; }
    public PieceTrollris ActivePiece { get; set; }
    public PieceTrollris ShadowPiece { get; set; }

    public int Score = 0;
    public int ClearedRows = 0;
    public int Level = 1;
    public int LevelSpeed = 500;
    public bool GameOver = false;
    public bool Paused = false;
    public bool Line = false;

    public BoardTrollris() {
      Grid = new GridCellInfoTrollris[24, 10];
      for (int i = 0; i < Grid.GetLength(0); i++) {
        for (int j = 0; j < Grid.GetLength(1); j++) {
          Grid[i, j] = new GridCellInfoTrollris();
        }
      }
    }

    /// <summary>
    /// This method updates the grid and moves the active piece down
    /// </summary>
    /// 
    public bool Update() {
      bool settled = false;
      Line = false;
      if (ActivePieceCanMove(MoveDirTrollris.DOWN)) {
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

    //Fuction that determines when an end state has been reached
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

    //Function that updates the position of the shadow piece
    public void UpdateShadow() {
      ShadowPiece.GridRow = ActivePiece.GridRow;
      while (ShadowPieceCanMove()) {
        ShadowPiece.MoveDown();
        RefreshGridWithShadowPiece();
      }
    }

    //Function that updates the grid cells to reflect the position of the shadow piece
    private void RefreshGridWithShadowPiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfoTrollris cellInfo = Grid[r, c];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_SHADOW_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < ShadowPiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < ShadowPiece.Layout.GetLength(1); c++) {
          if (ShadowPiece.Layout[r, c]) {
            GridCellInfoTrollris cellInfo = GetCellInfo(r + ShadowPiece.GridRow, c + ShadowPiece.GridCol);
            cellInfo?.SetToShadowPiece(ShadowPiece);
          }
        }
      }
    }

    //Function that updates the grid cells to reflect the position of the active piece
    private void RefreshGridWithActivePiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfoTrollris cellInfo = Grid[r, c];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_ACTIVE_PIECE) {
            cellInfo.Reset();
          }
        }
      }
      for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
          if (ActivePiece.Layout[r, c]) {
            GridCellInfoTrollris cellInfo = GetCellInfo(r + ActivePiece.GridRow, c + ActivePiece.GridCol);
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
    public GridCellInfoTrollris GetCellInfo(int row, int col) {
      if (row < 0 || row >= Grid.GetLength(0) || col < 0 || col >= Grid.GetLength(1))
        return null;
      else
        return Grid[row, col];
    }

    //Function that shifts the active piece over one column to the left if possible
    public void MoveActivePieceLeft() {
      if (ActivePieceCanMove(MoveDirTrollris.LEFT)) {
        ActivePiece.MoveLeft();
        ShadowPiece.MoveLeft();
        UpdateShadow();
        RefreshGridWithActivePiece();
      }
    }

    //Function that shifts the active piece over one column to the right if possible
    public void MoveActivePieceRight() {
      if (ActivePieceCanMove(MoveDirTrollris.RIGHT)) {
        ActivePiece.MoveRight();
        ShadowPiece.MoveRight();
        UpdateShadow();
        RefreshGridWithActivePiece();
      }
    }

    //Function that rotates the active piece right if possible
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

    //Function that rotates the active piece left if possible
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

    //Functoin that returns whether the shadow piece is capable of moving downward
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
        GridCellInfoTrollris cellInfo = GetCellInfo(ShadowPiece.GridRow + lastRow + 1, ShadowPiece.GridCol + c);
        if (cellInfo == null || cellInfo.State == CellStateTrollris.OCCUPIED_PREVIOUSLY) {
          canMove = false;
          break;
        }
      }
      return canMove;
    }
      
    //Function that returns whether the active piece can move in the given direction
    public bool ActivePieceCanMove(MoveDirTrollris moveDirTrollris) {
      bool canMove = true;
      switch (moveDirTrollris) {
        case MoveDirTrollris.DOWN:
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
            GridCellInfoTrollris cellInfo = GetCellInfo(ActivePiece.GridRow + lastRow + 1, ActivePiece.GridCol + c);
            if (cellInfo == null || cellInfo.State == CellStateTrollris.OCCUPIED_PREVIOUSLY) {
              canMove = false;
              break;
            }
          }
          break;

        case MoveDirTrollris.LEFT:
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
            GridCellInfoTrollris cellInfo = GetCellInfo(ActivePiece.GridRow + r, ActivePiece.GridCol + firstCol - 1);
            if (cellInfo == null || cellInfo.State == CellStateTrollris.OCCUPIED_PREVIOUSLY) {
              canMove = false;
              break;
            }
          }
          break;

        case MoveDirTrollris.RIGHT:
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
            GridCellInfoTrollris cellInfo = GetCellInfo(ActivePiece.GridRow + r, ActivePiece.GridCol + lastCol + 1);
            if (cellInfo == null || cellInfo.State == CellStateTrollris.OCCUPIED_PREVIOUSLY) {
              canMove = false;
              break;
            }
          }
          break;
      }
      return canMove;
    }

    //Function that returns whether the active piece is attempting to move out of the board
    private bool CheckForOutOfBounds() {
      for (int r = 0; r < ActivePiece.Layout.GetLength(0); r++) {
        for (int c = 0; c < ActivePiece.Layout.GetLength(1); c++) {
          if (ActivePiece.Layout[r, c]) {
            GridCellInfoTrollris cellInfo = GetCellInfo(r + ActivePiece.GridRow, c + ActivePiece.GridCol);
            if (cellInfo == null || cellInfo.State == CellStateTrollris.OCCUPIED_PREVIOUSLY) {
              return true;
            }
          }
        }
      }
      return false;
    }

    //Function that sets the active piece in place 
    public void SettlePiece() {
      for (int r = 0; r < Grid.GetLength(0); r++) {
        for (int c = 0; c < Grid.GetLength(1); c++) {
          GridCellInfoTrollris cellInfo = Grid[r, c];
          if (cellInfo.State == CellStateTrollris.OCCUPIED_ACTIVE_PIECE) {
            cellInfo.State = CellStateTrollris.OCCUPIED_PREVIOUSLY;
          }
        }
      }
    }

    //Functoin that determines whether there are any complete rows on the board and handles them
    public void CheckForLine() {
      int fullRows = 0;
      for (int curRow = 0; curRow < Grid.GetLength(0); curRow++) {
        bool allFilled = true;
        for (int col = 0; col < Grid.GetLength(1); col++) {
          if (GetCellInfo(curRow, col)?.State == CellStateTrollris.EMPTY) {
            allFilled = false;
            break;
          }
        }
        if (allFilled) {
          Line = true;
          fullRows++;
          for (int col = 0; col < Grid.GetLength(1); col++) {
            for (int dropRow = curRow; dropRow > 0; dropRow--) {
              Grid[dropRow, col] = Grid[dropRow - 1, col];
            }
            Grid[0, col] = new GridCellInfoTrollris();
          }
          curRow--;
        }
      }
      UpdateScore(fullRows);
    }

    //Function that move the  active piece as far down as possible
    public void DropPieceHard() {
      while (ActivePieceCanMove(MoveDirTrollris.DOWN)) {
        ActivePiece.MoveDown();
        RefreshGridWithActivePiece();
      }
      Update();
    }

    //Function that updates the score based on the number of rows completed
    private void UpdateScore(int fullRows) {
      ClearedRows += fullRows;
      if (fullRows > 0) {
        AddScore(fullRows);
      }
      LvlUP();
    }

    //Function that updates the score based on the rows completed
    private void AddScore(int fullrows) {
      switch (fullrows) {
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

    //Function that toggles whether the game is paused
    public void ChangePause() {
      if(Paused) {
        Paused = false;
      }
      else {
        Paused = true;
      }
    }

    //Function that changes the level based on the total number of rows cleard over the course of the game
    public void LvlUP() {
      if ((Level * 10) < ClearedRows && Level < 10) {
        Level++;
        LevelSpeed -= 40;
      }
    }
  }
}
