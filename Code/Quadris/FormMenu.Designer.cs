namespace Quadris
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.btnStartGame = new System.Windows.Forms.Button();
      this.lblQuadrisLogo = new System.Windows.Forms.Label();
      this.btnLeaderboard = new System.Windows.Forms.Button();
      this.btnQuitGame = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnStartGame
      // 
      this.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnStartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartGame.Location = new System.Drawing.Point(270, 225);
      this.btnStartGame.Margin = new System.Windows.Forms.Padding(0);
      this.btnStartGame.Name = "btnStartGame";
      this.btnStartGame.Size = new System.Drawing.Size(540, 100);
      this.btnStartGame.TabIndex = 1;
      this.btnStartGame.Text = "Start Game";
      this.btnStartGame.UseVisualStyleBackColor = true;
      this.btnStartGame.Click += new System.EventHandler(this.button1_Click);
      // 
      // lblQuadrisLogo
      // 
      this.lblQuadrisLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblQuadrisLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQuadrisLogo.ForeColor = System.Drawing.Color.White;
      this.lblQuadrisLogo.Location = new System.Drawing.Point(0, 0);
      this.lblQuadrisLogo.Margin = new System.Windows.Forms.Padding(0);
      this.lblQuadrisLogo.Name = "lblQuadrisLogo";
      this.lblQuadrisLogo.Size = new System.Drawing.Size(1080, 200);
      this.lblQuadrisLogo.TabIndex = 0;
      this.lblQuadrisLogo.Text = "Quadris";
      this.lblQuadrisLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.lblQuadrisLogo.Click += new System.EventHandler(this.lblQuadrisLogo_Click);
      // 
      // btnLeaderboard
      // 
      this.btnLeaderboard.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLeaderboard.Location = new System.Drawing.Point(270, 350);
      this.btnLeaderboard.Name = "btnLeaderboard";
      this.btnLeaderboard.Size = new System.Drawing.Size(540, 100);
      this.btnLeaderboard.TabIndex = 2;
      this.btnLeaderboard.Text = "Leaderboard";
      this.btnLeaderboard.UseVisualStyleBackColor = true;
      this.btnLeaderboard.Click += new System.EventHandler(this.btnLeaderboard_Click);
      // 
      // btnQuitGame
      // 
      this.btnQuitGame.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnQuitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuitGame.Location = new System.Drawing.Point(270, 475);
      this.btnQuitGame.Name = "btnQuitGame";
      this.btnQuitGame.Size = new System.Drawing.Size(540, 100);
      this.btnQuitGame.TabIndex = 3;
      this.btnQuitGame.Text = "Quit";
      this.btnQuitGame.UseVisualStyleBackColor = true;
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(1048, 632);
      this.Controls.Add(this.btnQuitGame);
      this.Controls.Add(this.btnLeaderboard);
      this.Controls.Add(this.lblQuadrisLogo);
      this.Controls.Add(this.btnStartGame);
      this.MaximizeBox = false;
      this.Name = "FormMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quadris Main Menu";
      this.Load += new System.EventHandler(this.FormMenu_Load);
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button btnStartGame;
    private System.Windows.Forms.Label lblQuadrisLogo;
    private System.Windows.Forms.Button btnLeaderboard;
    private System.Windows.Forms.Button btnQuitGame;
  }
}