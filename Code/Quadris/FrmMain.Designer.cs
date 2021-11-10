
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panBoard
            // 
            this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panBoard.Location = new System.Drawing.Point(328, 167);
            this.panBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(44, 65);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 105);
            this.panel1.TabIndex = 2;
            // 
            // lblNextPiece
            // 
            this.lblNextPiece.AutoSize = true;
            this.lblNextPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNextPiece.ForeColor = System.Drawing.Color.White;
            this.lblNextPiece.Location = new System.Drawing.Point(38, 32);
            this.lblNextPiece.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNextPiece.Name = "lblNextPiece";
            this.lblNextPiece.Size = new System.Drawing.Size(147, 29);
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
            this.lblScore.Location = new System.Drawing.Point(320, 125);
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
            this.lblScoreNum.Location = new System.Drawing.Point(430, 125);
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
            this.lblLevel.Location = new System.Drawing.Point(328, 666);
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
            this.lblLevelNum.Location = new System.Drawing.Point(430, 666);
            this.lblLevelNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevelNum.Name = "lblLevelNum";
            this.lblLevelNum.Size = new System.Drawing.Size(36, 39);
            this.lblLevelNum.TabIndex = 7;
            this.lblLevelNum.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 368);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label4.Size = new System.Drawing.Size(109, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Z : Rotate Left";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 414);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "X : Rotate Right";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 460);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label3.Size = new System.Drawing.Size(174, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Right Arrow : Move Right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(35, 507);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label5.Size = new System.Drawing.Size(156, 37);
            this.label5.TabIndex = 14;
            this.label5.Text = "Left Arrow : Move Left";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(41, 560);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label6.Size = new System.Drawing.Size(168, 37);
            this.label6.TabIndex = 15;
            this.label6.Text = "Down Arrow : Speed Up";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(41, 621);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.label7.Size = new System.Drawing.Size(95, 37);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tab : Pause";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1040, 746);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLevelNum);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblScoreNum);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblNextPiece);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panBoard);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

