
namespace Quadris {
  partial class FrmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      this.panBoard = new System.Windows.Forms.Panel();
      this.tmrFps = new System.Windows.Forms.Timer(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblNextPiece = new System.Windows.Forms.Label();
      this.lblScore = new System.Windows.Forms.Label();
      this.lblScoreNum = new System.Windows.Forms.Label();
      this.lblLevel = new System.Windows.Forms.Label();
      this.lblLevelNum = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // panBoard
      // 
      this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panBoard.Location = new System.Drawing.Point(656, 324);
      this.panBoard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.panBoard.Name = "panBoard";
      this.panBoard.Size = new System.Drawing.Size(527, 948);
      this.panBoard.TabIndex = 1;
      this.panBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panBoard_Paint);
      // 
      // tmrFps
      // 
      this.tmrFps.Enabled = true;
      this.tmrFps.Interval = 500;
      this.tmrFps.Tick += new System.EventHandler(this.tmrFps_Tick);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Location = new System.Drawing.Point(88, 126);
      this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(273, 200);
      this.panel1.TabIndex = 2;
      // 
      // lblNextPiece
      // 
      this.lblNextPiece.AutoSize = true;
      this.lblNextPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNextPiece.ForeColor = System.Drawing.Color.White;
      this.lblNextPiece.Location = new System.Drawing.Point(77, 62);
      this.lblNextPiece.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblNextPiece.Name = "lblNextPiece";
      this.lblNextPiece.Size = new System.Drawing.Size(280, 55);
      this.lblNextPiece.TabIndex = 3;
      this.lblNextPiece.Text = "Next Piece:";
      this.lblNextPiece.Click += new System.EventHandler(this.lblNextPiece_Click);
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.BackColor = System.Drawing.Color.Transparent;
      this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScore.ForeColor = System.Drawing.Color.White;
      this.lblScore.Location = new System.Drawing.Point(640, 243);
      this.lblScore.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(245, 76);
      this.lblScore.TabIndex = 4;
      this.lblScore.Text = "Score: ";
      this.lblScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      this.lblScore.Click += new System.EventHandler(this.label1_Click);
      // 
      // lblScoreNum
      // 
      this.lblScoreNum.AutoSize = true;
      this.lblScoreNum.BackColor = System.Drawing.Color.Transparent;
      this.lblScoreNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScoreNum.ForeColor = System.Drawing.Color.White;
      this.lblScoreNum.Location = new System.Drawing.Point(861, 243);
      this.lblScoreNum.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblScoreNum.Name = "lblScoreNum";
      this.lblScoreNum.Size = new System.Drawing.Size(70, 76);
      this.lblScoreNum.TabIndex = 5;
      this.lblScoreNum.Text = "0";
      this.lblScoreNum.Click += new System.EventHandler(this.label1_Click_1);
      // 
      // lblLevel
      // 
      this.lblLevel.AutoSize = true;
      this.lblLevel.BackColor = System.Drawing.Color.Transparent;
      this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLevel.ForeColor = System.Drawing.Color.White;
      this.lblLevel.Location = new System.Drawing.Point(656, 1290);
      this.lblLevel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblLevel.Name = "lblLevel";
      this.lblLevel.Size = new System.Drawing.Size(229, 76);
      this.lblLevel.TabIndex = 6;
      this.lblLevel.Text = "Level: ";
      // 
      // lblLevelNum
      // 
      this.lblLevelNum.AutoSize = true;
      this.lblLevelNum.BackColor = System.Drawing.Color.Transparent;
      this.lblLevelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLevelNum.ForeColor = System.Drawing.Color.White;
      this.lblLevelNum.Location = new System.Drawing.Point(861, 1290);
      this.lblLevelNum.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
      this.lblLevelNum.Name = "lblLevelNum";
      this.lblLevelNum.Size = new System.Drawing.Size(70, 76);
      this.lblLevelNum.TabIndex = 7;
      this.lblLevelNum.Text = "1";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(2053, 1643);
      this.Controls.Add(this.lblLevelNum);
      this.Controls.Add(this.lblLevel);
      this.Controls.Add(this.lblScoreNum);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.lblNextPiece);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panBoard);
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.Name = "FrmMain";
      this.Text = "Quadris!";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel panBoard;
    private System.Windows.Forms.Timer tmrFps;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblNextPiece;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Label lblScoreNum;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label lblLevelNum;
  }
}

