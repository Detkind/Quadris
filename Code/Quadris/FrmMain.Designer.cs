
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
	  this.panelNextPiece = new System.Windows.Forms.Panel();
	  this.lblNextPiece = new System.Windows.Forms.Label();
	  this.lblScore = new System.Windows.Forms.Label();
	  this.lblScoreNum = new System.Windows.Forms.Label();
	  this.lblLevel = new System.Windows.Forms.Label();
	  this.lblLevelNum = new System.Windows.Forms.Label();
	  this.panel1 = new System.Windows.Forms.Panel();
	  this.label13 = new System.Windows.Forms.Label();
	  this.label12 = new System.Windows.Forms.Label();
	  this.label11 = new System.Windows.Forms.Label();
	  this.label10 = new System.Windows.Forms.Label();
	  this.label9 = new System.Windows.Forms.Label();
	  this.label8 = new System.Windows.Forms.Label();
	  this.panel2HeldPiece = new System.Windows.Forms.Panel();
	  this.panel1.SuspendLayout();
	  this.SuspendLayout();
	  // 
	  // panBoard
	  // 
	  this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
	  this.panBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	  this.panBoard.Location = new System.Drawing.Point(254, 72);
	  this.panBoard.Margin = new System.Windows.Forms.Padding(4);
	  this.panBoard.Name = "panBoard";
	  this.panBoard.Size = new System.Drawing.Size(266, 491);
	  this.panBoard.TabIndex = 1;
	  this.panBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.panBoard_Paint);
	  // 
	  // tmrFps
	  // 
	  this.tmrFps.Enabled = true;
	  this.tmrFps.Interval = 500;
	  this.tmrFps.Tick += new System.EventHandler(this.tmrFps_Tick);
	  // 
	  // panelNextPiece
	  // 
	  this.panelNextPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
	  this.panelNextPiece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	  this.panelNextPiece.Location = new System.Drawing.Point(53, 72);
	  this.panelNextPiece.Margin = new System.Windows.Forms.Padding(0);
	  this.panelNextPiece.Name = "panelNextPiece";
	  this.panelNextPiece.Size = new System.Drawing.Size(152, 157);
	  this.panelNextPiece.TabIndex = 2;
	  // 
	  // lblNextPiece
	  // 
	  this.lblNextPiece.AutoSize = true;
	  this.lblNextPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.lblNextPiece.ForeColor = System.Drawing.Color.White;
	  this.lblNextPiece.Location = new System.Drawing.Point(14, 32);
	  this.lblNextPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	  this.lblNextPiece.Name = "lblNextPiece";
	  this.lblNextPiece.Size = new System.Drawing.Size(191, 39);
	  this.lblNextPiece.TabIndex = 3;
	  this.lblNextPiece.Text = "Next Piece:";
	  this.lblNextPiece.UseMnemonic = false;
	  this.lblNextPiece.Click += new System.EventHandler(this.lblNextPiece_Click);
	  // 
	  // lblScore
	  // 
	  this.lblScore.AutoSize = true;
	  this.lblScore.BackColor = System.Drawing.Color.Transparent;
	  this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.lblScore.ForeColor = System.Drawing.Color.White;
	  this.lblScore.Location = new System.Drawing.Point(246, 30);
	  this.lblScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	  this.lblScore.Name = "lblScore";
	  this.lblScore.Size = new System.Drawing.Size(124, 39);
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
	  this.lblScoreNum.Location = new System.Drawing.Point(356, 30);
	  this.lblScoreNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	  this.lblScoreNum.Name = "lblScoreNum";
	  this.lblScoreNum.Size = new System.Drawing.Size(36, 39);
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
	  this.lblLevel.Location = new System.Drawing.Point(254, 571);
	  this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	  this.lblLevel.Name = "lblLevel";
	  this.lblLevel.Size = new System.Drawing.Size(117, 39);
	  this.lblLevel.TabIndex = 6;
	  this.lblLevel.Text = "Level: ";
	  // 
	  // lblLevelNum
	  // 
	  this.lblLevelNum.AutoSize = true;
	  this.lblLevelNum.BackColor = System.Drawing.Color.Transparent;
	  this.lblLevelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
	  this.lblLevelNum.ForeColor = System.Drawing.Color.White;
	  this.lblLevelNum.Location = new System.Drawing.Point(356, 571);
	  this.lblLevelNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
	  this.lblLevelNum.Name = "lblLevelNum";
	  this.lblLevelNum.Size = new System.Drawing.Size(36, 39);
	  this.lblLevelNum.TabIndex = 7;
	  this.lblLevelNum.Text = "1";
	  // 
	  // panel1
	  // 
	  this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
	  this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	  this.panel1.Controls.Add(this.label13);
	  this.panel1.Controls.Add(this.label12);
	  this.panel1.Controls.Add(this.label11);
	  this.panel1.Controls.Add(this.label10);
	  this.panel1.Controls.Add(this.label9);
	  this.panel1.Controls.Add(this.label8);
	  this.panel1.Location = new System.Drawing.Point(35, 373);
	  this.panel1.Name = "panel1";
	  this.panel1.Size = new System.Drawing.Size(188, 237);
	  this.panel1.TabIndex = 8;
	  // 
	  // label13
	  // 
	  this.label13.AutoSize = true;
	  this.label13.ForeColor = System.Drawing.Color.White;
	  this.label13.Location = new System.Drawing.Point(40, 190);
	  this.label13.Name = "label13";
	  this.label13.Size = new System.Drawing.Size(85, 17);
	  this.label13.TabIndex = 5;
	  this.label13.Text = "Tab : Pause";
	  // 
	  // label12
	  // 
	  this.label12.AutoSize = true;
	  this.label12.ForeColor = System.Drawing.Color.White;
	  this.label12.Location = new System.Drawing.Point(40, 155);
	  this.label12.Name = "label12";
	  this.label12.Size = new System.Drawing.Size(90, 17);
	  this.label12.TabIndex = 4;
	  this.label12.Text = "v : Speed Up";
	  // 
	  // label11
	  // 
	  this.label11.AutoSize = true;
	  this.label11.ForeColor = System.Drawing.Color.White;
	  this.label11.Location = new System.Drawing.Point(40, 120);
	  this.label11.Name = "label11";
	  this.label11.Size = new System.Drawing.Size(99, 17);
	  this.label11.TabIndex = 3;
	  this.label11.Text = "> : Move Right";
	  // 
	  // label10
	  // 
	  this.label10.AutoSize = true;
	  this.label10.ForeColor = System.Drawing.Color.White;
	  this.label10.Location = new System.Drawing.Point(40, 85);
	  this.label10.Name = "label10";
	  this.label10.Size = new System.Drawing.Size(90, 17);
	  this.label10.TabIndex = 2;
	  this.label10.Text = "< : Move Left";
	  // 
	  // label9
	  // 
	  this.label9.AutoSize = true;
	  this.label9.ForeColor = System.Drawing.Color.White;
	  this.label9.Location = new System.Drawing.Point(40, 50);
	  this.label9.Name = "label9";
	  this.label9.Size = new System.Drawing.Size(108, 17);
	  this.label9.TabIndex = 1;
	  this.label9.Text = "X : Rotate Right";
	  // 
	  // label8
	  // 
	  this.label8.AutoSize = true;
	  this.label8.ForeColor = System.Drawing.Color.White;
	  this.label8.Location = new System.Drawing.Point(40, 15);
	  this.label8.Name = "label8";
	  this.label8.Size = new System.Drawing.Size(99, 17);
	  this.label8.TabIndex = 0;
	  this.label8.Text = "Z : Rotate Left";
	  // 
	  // panel2HeldPiece
	  // 
	  this.panel2HeldPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
	  this.panel2HeldPiece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
	  this.panel2HeldPiece.Location = new System.Drawing.Point(577, 72);
	  this.panel2HeldPiece.Margin = new System.Windows.Forms.Padding(0);
	  this.panel2HeldPiece.Name = "panel2HeldPiece";
	  this.panel2HeldPiece.Size = new System.Drawing.Size(152, 157);
	  this.panel2HeldPiece.TabIndex = 9;
	  this.panel2HeldPiece.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2HeldPiece_Paint);
	  // 
	  // FrmMain
	  // 
	  this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
	  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
	  this.BackColor = System.Drawing.Color.Black;
	  this.ClientSize = new System.Drawing.Size(805, 652);
	  this.Controls.Add(this.panel2HeldPiece);
	  this.Controls.Add(this.panel1);
	  this.Controls.Add(this.lblLevelNum);
	  this.Controls.Add(this.lblLevel);
	  this.Controls.Add(this.lblScoreNum);
	  this.Controls.Add(this.lblScore);
	  this.Controls.Add(this.lblNextPiece);
	  this.Controls.Add(this.panelNextPiece);
	  this.Controls.Add(this.panBoard);
	  this.Margin = new System.Windows.Forms.Padding(4);
	  this.MaximizeBox = false;
	  this.Name = "FrmMain";
	  this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
	  this.Text = "Quadris!";
	  this.Load += new System.EventHandler(this.FrmMain_Load);
	  this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
	  this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyUp);
	  this.panel1.ResumeLayout(false);
	  this.panel1.PerformLayout();
	  this.ResumeLayout(false);
	  this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel panBoard;
    private System.Windows.Forms.Timer tmrFps;
    private System.Windows.Forms.Panel panelNextPiece;
    private System.Windows.Forms.Label lblNextPiece;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Label lblScoreNum;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label lblLevelNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
	private System.Windows.Forms.Panel panel2HeldPiece;
  }
}

