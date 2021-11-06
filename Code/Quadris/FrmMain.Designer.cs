
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
      this.SuspendLayout();
      // 
      // panBoard
      // 
      this.panBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
      this.panBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.panBoard.Location = new System.Drawing.Point(560, 265);
      this.panBoard.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.panBoard.Name = "panBoard";
      this.panBoard.Size = new System.Drawing.Size(772, 841);
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
      this.panel1.Location = new System.Drawing.Point(96, 126);
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
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(2053, 1643);
      this.Controls.Add(this.lblNextPiece);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panBoard);
      this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
      this.Name = "FrmMain";
      this.Text = "Quadris!";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Panel panBoard;
    private System.Windows.Forms.Timer tmrFps;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label lblNextPiece;
  }
}

