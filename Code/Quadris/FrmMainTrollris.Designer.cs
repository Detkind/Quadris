﻿
namespace Quadris {
  partial class FrmMainTrollris {
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
      this.tmrFps = new System.Windows.Forms.Timer(this.components);
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnQuadrisUnmuted = new System.Windows.Forms.Button();
      this.btnQuadrisMuted = new System.Windows.Forms.Button();
      this.label14 = new System.Windows.Forms.Label();
      this.panel2HeldPiece = new System.Windows.Forms.Panel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label16 = new System.Windows.Forms.Label();
      this.label15 = new System.Windows.Forms.Label();
      this.label13 = new System.Windows.Forms.Label();
      this.label12 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.lblLevelNum = new System.Windows.Forms.Label();
      this.lblLevel = new System.Windows.Forms.Label();
      this.lblScoreNum = new System.Windows.Forms.Label();
      this.lblScore = new System.Windows.Forms.Label();
      this.lblNextPiece = new System.Windows.Forms.Label();
      this.panelNextPiece = new System.Windows.Forms.Panel();
      this.panBoard = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tmrFps
      // 
      this.tmrFps.Enabled = true;
      this.tmrFps.Interval = 500;
      this.tmrFps.Tick += new System.EventHandler(this.tmrFps_Tick);
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.Color.Black;
      this.textBox1.Location = new System.Drawing.Point(430, 543);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(2, 20);
      this.textBox1.TabIndex = 14;
      // 
      // btnQuadrisUnmuted
      // 
      this.btnQuadrisUnmuted.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnQuadrisUnmuted.Image = global::Quadris.Properties.Resources.unmuteIcon;
      this.btnQuadrisUnmuted.Location = new System.Drawing.Point(15, 595);
      this.btnQuadrisUnmuted.Name = "btnQuadrisUnmuted";
      this.btnQuadrisUnmuted.Size = new System.Drawing.Size(30, 30);
      this.btnQuadrisUnmuted.TabIndex = 15;
      this.btnQuadrisUnmuted.TabStop = false;
      this.btnQuadrisUnmuted.UseVisualStyleBackColor = true;
      this.btnQuadrisUnmuted.Click += new System.EventHandler(this.btnTrollrisUnmuted_Click);
      // 
      // btnQuadrisMuted
      // 
      this.btnQuadrisMuted.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnQuadrisMuted.Image = global::Quadris.Properties.Resources.muteIcon;
      this.btnQuadrisMuted.Location = new System.Drawing.Point(15, 595);
      this.btnQuadrisMuted.Name = "btnQuadrisMuted";
      this.btnQuadrisMuted.Size = new System.Drawing.Size(30, 30);
      this.btnQuadrisMuted.TabIndex = 16;
      this.btnQuadrisMuted.TabStop = false;
      this.btnQuadrisMuted.UseVisualStyleBackColor = true;
      this.btnQuadrisMuted.Click += new System.EventHandler(this.btnTrollrisMuted_Click);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.ForeColor = System.Drawing.Color.White;
      this.label14.Location = new System.Drawing.Point(424, 25);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(153, 31);
      this.label14.TabIndex = 17;
      this.label14.Text = "Hold Piece:";
      this.label14.UseMnemonic = false;
      // 
      // panel2HeldPiece
      // 
      this.panel2HeldPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panel2HeldPiece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel2HeldPiece.Location = new System.Drawing.Point(450, 59);
      this.panel2HeldPiece.Margin = new System.Windows.Forms.Padding(0);
      this.panel2HeldPiece.Name = "panel2HeldPiece";
      this.panel2HeldPiece.Size = new System.Drawing.Size(115, 128);
      this.panel2HeldPiece.TabIndex = 18;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panel1.Controls.Add(this.label16);
      this.panel1.Controls.Add(this.label15);
      this.panel1.Controls.Add(this.label13);
      this.panel1.Controls.Add(this.label12);
      this.panel1.Controls.Add(this.label11);
      this.panel1.Controls.Add(this.label10);
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Location = new System.Drawing.Point(26, 303);
      this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(142, 193);
      this.panel1.TabIndex = 19;
      // 
      // label16
      // 
      this.label16.AutoSize = true;
      this.label16.ForeColor = System.Drawing.Color.White;
      this.label16.Location = new System.Drawing.Point(25, 160);
      this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label16.Name = "label16";
      this.label16.Size = new System.Drawing.Size(53, 13);
      this.label16.TabIndex = 7;
      this.label16.Text = "P : Pause";
      // 
      // label15
      // 
      this.label15.AutoSize = true;
      this.label15.ForeColor = System.Drawing.Color.White;
      this.label15.Location = new System.Drawing.Point(25, 140);
      this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label15.Name = "label15";
      this.label15.Size = new System.Drawing.Size(45, 13);
      this.label15.TabIndex = 6;
      this.label15.Text = "C : Hold";
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.ForeColor = System.Drawing.Color.White;
      this.label13.Location = new System.Drawing.Point(25, 120);
      this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(96, 13);
      this.label13.TabIndex = 5;
      this.label13.Text = "Space : Drop Hard";
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.ForeColor = System.Drawing.Color.White;
      this.label12.Location = new System.Drawing.Point(25, 100);
      this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(67, 13);
      this.label12.TabIndex = 4;
      this.label12.Text = "↓ : Drop Soft";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.ForeColor = System.Drawing.Color.White;
      this.label11.Location = new System.Drawing.Point(25, 80);
      this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(82, 13);
      this.label11.TabIndex = 3;
      this.label11.Text = "→ : Move Right";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.ForeColor = System.Drawing.Color.White;
      this.label10.Location = new System.Drawing.Point(25, 60);
      this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(75, 13);
      this.label10.TabIndex = 2;
      this.label10.Text = "← : Move Left";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.ForeColor = System.Drawing.Color.White;
      this.label9.Location = new System.Drawing.Point(25, 40);
      this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(83, 13);
      this.label9.TabIndex = 1;
      this.label9.Text = "X : Rotate Right";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new System.Drawing.Point(25, 20);
      this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(76, 13);
      this.label8.TabIndex = 0;
      this.label8.Text = "Z : Rotate Left";
      // 
      // lblLevelNum
      // 
      this.lblLevelNum.AutoSize = true;
      this.lblLevelNum.BackColor = System.Drawing.Color.Transparent;
      this.lblLevelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLevelNum.ForeColor = System.Drawing.Color.White;
      this.lblLevelNum.Location = new System.Drawing.Point(265, 465);
      this.lblLevelNum.Margin = new System.Windows.Forms.Padding(0);
      this.lblLevelNum.Name = "lblLevelNum";
      this.lblLevelNum.Size = new System.Drawing.Size(29, 31);
      this.lblLevelNum.TabIndex = 20;
      this.lblLevelNum.Text = "1";
      // 
      // lblLevel
      // 
      this.lblLevel.AutoSize = true;
      this.lblLevel.BackColor = System.Drawing.Color.Transparent;
      this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblLevel.ForeColor = System.Drawing.Color.White;
      this.lblLevel.Location = new System.Drawing.Point(188, 465);
      this.lblLevel.Margin = new System.Windows.Forms.Padding(0);
      this.lblLevel.Name = "lblLevel";
      this.lblLevel.Size = new System.Drawing.Size(94, 31);
      this.lblLevel.TabIndex = 21;
      this.lblLevel.Text = "Level: ";
      // 
      // lblScoreNum
      // 
      this.lblScoreNum.AutoSize = true;
      this.lblScoreNum.BackColor = System.Drawing.Color.Transparent;
      this.lblScoreNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScoreNum.ForeColor = System.Drawing.Color.White;
      this.lblScoreNum.Location = new System.Drawing.Point(270, 24);
      this.lblScoreNum.Name = "lblScoreNum";
      this.lblScoreNum.Size = new System.Drawing.Size(29, 31);
      this.lblScoreNum.TabIndex = 22;
      this.lblScoreNum.Text = "0";
      // 
      // lblScore
      // 
      this.lblScore.AutoSize = true;
      this.lblScore.BackColor = System.Drawing.Color.Transparent;
      this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblScore.ForeColor = System.Drawing.Color.White;
      this.lblScore.Location = new System.Drawing.Point(183, 24);
      this.lblScore.Name = "lblScore";
      this.lblScore.Size = new System.Drawing.Size(100, 31);
      this.lblScore.TabIndex = 23;
      this.lblScore.Text = "Score: ";
      this.lblScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      // 
      // lblNextPiece
      // 
      this.lblNextPiece.AutoSize = true;
      this.lblNextPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNextPiece.ForeColor = System.Drawing.Color.White;
      this.lblNextPiece.Location = new System.Drawing.Point(11, 25);
      this.lblNextPiece.Name = "lblNextPiece";
      this.lblNextPiece.Size = new System.Drawing.Size(153, 31);
      this.lblNextPiece.TabIndex = 24;
      this.lblNextPiece.Text = "Next Piece:";
      this.lblNextPiece.UseMnemonic = false;
      // 
      // panelNextPiece
      // 
      this.panelNextPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panelNextPiece.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panelNextPiece.Location = new System.Drawing.Point(38, 59);
      this.panelNextPiece.Margin = new System.Windows.Forms.Padding(0);
      this.panelNextPiece.Name = "panelNextPiece";
      this.panelNextPiece.Size = new System.Drawing.Size(115, 128);
      this.panelNextPiece.TabIndex = 25;
      // 
      // panBoard
      // 
      this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panBoard.Location = new System.Drawing.Point(188, 59);
      this.panBoard.Margin = new System.Windows.Forms.Padding(0);
      this.panBoard.Name = "panBoard";
      this.panBoard.Size = new System.Drawing.Size(200, 400);
      this.panBoard.TabIndex = 26;
      // 
      // FrmMainTrollris
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(604, 645);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.btnQuadrisUnmuted);
      this.Controls.Add(this.btnQuadrisMuted);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.panel2HeldPiece);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.lblLevelNum);
      this.Controls.Add(this.lblLevel);
      this.Controls.Add(this.lblScoreNum);
      this.Controls.Add(this.lblScore);
      this.Controls.Add(this.lblNextPiece);
      this.Controls.Add(this.panelNextPiece);
      this.Controls.Add(this.panBoard);
      this.MaximizeBox = false;
      this.Name = "FrmMainTrollris";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Trollris!";
      this.Load += new System.EventHandler(this.FrmMainTrollris_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer tmrFps;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnQuadrisUnmuted;
    private System.Windows.Forms.Button btnQuadrisMuted;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Panel panel2HeldPiece;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblLevelNum;
    private System.Windows.Forms.Label lblLevel;
    private System.Windows.Forms.Label lblScoreNum;
    private System.Windows.Forms.Label lblScore;
    private System.Windows.Forms.Label lblNextPiece;
    private System.Windows.Forms.Panel panelNextPiece;
    private System.Windows.Forms.Panel panBoard;
  }
}