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
      this.btnStartQuadris = new System.Windows.Forms.Button();
      this.lblQuadrisLogo = new System.Windows.Forms.Label();
      this.btnLeaderboardQuadris = new System.Windows.Forms.Button();
      this.btnQuitQuadris = new System.Windows.Forms.Button();
      this.panelQuadrisMenu = new System.Windows.Forms.Panel();
      this.panelTrollrisMenu = new System.Windows.Forms.Panel();
      this.btnSwitchToQuadris = new System.Windows.Forms.Button();
      this.btnQuitTrollris = new System.Windows.Forms.Button();
      this.btnLeaderboardTrollris = new System.Windows.Forms.Button();
      this.btnStartTrollris = new System.Windows.Forms.Button();
      this.lblTrollrisLogo = new System.Windows.Forms.Label();
      this.btnSwitchToTrollris = new System.Windows.Forms.Button();
      this.panelQuadrisMenu.SuspendLayout();
      this.panelTrollrisMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnStartQuadris
      // 
      this.btnStartQuadris.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnStartQuadris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnStartQuadris.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnStartQuadris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartQuadris.Location = new System.Drawing.Point(270, 225);
      this.btnStartQuadris.Margin = new System.Windows.Forms.Padding(0);
      this.btnStartQuadris.Name = "btnStartQuadris";
      this.btnStartQuadris.Size = new System.Drawing.Size(540, 100);
      this.btnStartQuadris.TabIndex = 1;
      this.btnStartQuadris.Text = "Start Game";
      this.btnStartQuadris.UseVisualStyleBackColor = true;
      this.btnStartQuadris.Click += new System.EventHandler(this.btnStartQuadris_Click);
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
      // 
      // btnLeaderboardQuadris
      // 
      this.btnLeaderboardQuadris.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnLeaderboardQuadris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLeaderboardQuadris.Location = new System.Drawing.Point(270, 350);
      this.btnLeaderboardQuadris.Name = "btnLeaderboardQuadris";
      this.btnLeaderboardQuadris.Size = new System.Drawing.Size(540, 100);
      this.btnLeaderboardQuadris.TabIndex = 2;
      this.btnLeaderboardQuadris.Text = "Leaderboard";
      this.btnLeaderboardQuadris.UseVisualStyleBackColor = true;
      this.btnLeaderboardQuadris.Click += new System.EventHandler(this.btnLeaderboard_Click);
      // 
      // btnQuitQuadris
      // 
      this.btnQuitQuadris.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnQuitQuadris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuitQuadris.Location = new System.Drawing.Point(270, 475);
      this.btnQuitQuadris.Name = "btnQuitQuadris";
      this.btnQuitQuadris.Size = new System.Drawing.Size(540, 100);
      this.btnQuitQuadris.TabIndex = 3;
      this.btnQuitQuadris.Text = "Quit";
      this.btnQuitQuadris.UseVisualStyleBackColor = true;
      this.btnQuitQuadris.Click += new System.EventHandler(this.btnQuitQuadris_Click);
      // 
      // panelQuadrisMenu
      // 
      this.panelQuadrisMenu.Controls.Add(this.btnSwitchToTrollris);
      this.panelQuadrisMenu.Controls.Add(this.lblQuadrisLogo);
      this.panelQuadrisMenu.Controls.Add(this.btnQuitQuadris);
      this.panelQuadrisMenu.Controls.Add(this.btnStartQuadris);
      this.panelQuadrisMenu.Controls.Add(this.btnLeaderboardQuadris);
      this.panelQuadrisMenu.Location = new System.Drawing.Point(0, 0);
      this.panelQuadrisMenu.Name = "panelQuadrisMenu";
      this.panelQuadrisMenu.Size = new System.Drawing.Size(1080, 720);
      this.panelQuadrisMenu.TabIndex = 4;
      // 
      // panelTrollrisMenu
      // 
      this.panelTrollrisMenu.Controls.Add(this.btnSwitchToQuadris);
      this.panelTrollrisMenu.Controls.Add(this.btnQuitTrollris);
      this.panelTrollrisMenu.Controls.Add(this.btnLeaderboardTrollris);
      this.panelTrollrisMenu.Controls.Add(this.btnStartTrollris);
      this.panelTrollrisMenu.Controls.Add(this.lblTrollrisLogo);
      this.panelTrollrisMenu.Location = new System.Drawing.Point(0, 0);
      this.panelTrollrisMenu.Name = "panelTrollrisMenu";
      this.panelTrollrisMenu.Size = new System.Drawing.Size(1080, 720);
      this.panelTrollrisMenu.TabIndex = 5;
      // 
      // btnSwitchToQuadris
      // 
      this.btnSwitchToQuadris.Location = new System.Drawing.Point(775, 640);
      this.btnSwitchToQuadris.Name = "btnSwitchToQuadris";
      this.btnSwitchToQuadris.Size = new System.Drawing.Size(300, 75);
      this.btnSwitchToQuadris.TabIndex = 5;
      this.btnSwitchToQuadris.Text = "Switch to Quadris";
      this.btnSwitchToQuadris.UseVisualStyleBackColor = true;
      this.btnSwitchToQuadris.Click += new System.EventHandler(this.btnSwitchToQuadris_Click);
      // 
      // btnQuitTrollris
      // 
      this.btnQuitTrollris.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnQuitTrollris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuitTrollris.Location = new System.Drawing.Point(270, 475);
      this.btnQuitTrollris.Name = "btnQuitTrollris";
      this.btnQuitTrollris.Size = new System.Drawing.Size(540, 100);
      this.btnQuitTrollris.TabIndex = 4;
      this.btnQuitTrollris.Text = "Quit";
      this.btnQuitTrollris.UseVisualStyleBackColor = true;
      // 
      // btnLeaderboardTrollris
      // 
      this.btnLeaderboardTrollris.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnLeaderboardTrollris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLeaderboardTrollris.Location = new System.Drawing.Point(270, 350);
      this.btnLeaderboardTrollris.Name = "btnLeaderboardTrollris";
      this.btnLeaderboardTrollris.Size = new System.Drawing.Size(540, 100);
      this.btnLeaderboardTrollris.TabIndex = 3;
      this.btnLeaderboardTrollris.Text = "Leaderboard";
      this.btnLeaderboardTrollris.UseVisualStyleBackColor = true;
      // 
      // btnStartTrollris
      // 
      this.btnStartTrollris.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnStartTrollris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.btnStartTrollris.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnStartTrollris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnStartTrollris.Location = new System.Drawing.Point(270, 225);
      this.btnStartTrollris.Margin = new System.Windows.Forms.Padding(0);
      this.btnStartTrollris.Name = "btnStartTrollris";
      this.btnStartTrollris.Size = new System.Drawing.Size(540, 100);
      this.btnStartTrollris.TabIndex = 2;
      this.btnStartTrollris.Text = "Start Game";
      this.btnStartTrollris.UseVisualStyleBackColor = true;
      // 
      // lblTrollrisLogo
      // 
      this.lblTrollrisLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lblTrollrisLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTrollrisLogo.ForeColor = System.Drawing.Color.White;
      this.lblTrollrisLogo.Location = new System.Drawing.Point(0, 0);
      this.lblTrollrisLogo.Margin = new System.Windows.Forms.Padding(0);
      this.lblTrollrisLogo.Name = "lblTrollrisLogo";
      this.lblTrollrisLogo.Size = new System.Drawing.Size(1080, 200);
      this.lblTrollrisLogo.TabIndex = 1;
      this.lblTrollrisLogo.Text = "Trollris";
      this.lblTrollrisLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnSwitchToTrollris
      // 
      this.btnSwitchToTrollris.Location = new System.Drawing.Point(775, 640);
      this.btnSwitchToTrollris.Name = "btnSwitchToTrollris";
      this.btnSwitchToTrollris.Size = new System.Drawing.Size(300, 75);
      this.btnSwitchToTrollris.TabIndex = 4;
      this.btnSwitchToTrollris.Text = "Switch to Trollris";
      this.btnSwitchToTrollris.UseVisualStyleBackColor = true;
      this.btnSwitchToTrollris.Click += new System.EventHandler(this.btnSwitchToTrollris_Click);
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.Color.Black;
      this.ClientSize = new System.Drawing.Size(2238, 1225);
      this.Controls.Add(this.panelTrollrisMenu);
      this.Controls.Add(this.panelQuadrisMenu);
      this.MaximizeBox = false;
      this.Name = "FormMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Quadris Main Menu";
      this.Load += new System.EventHandler(this.FormMenu_Load);
      this.panelQuadrisMenu.ResumeLayout(false);
      this.panelTrollrisMenu.ResumeLayout(false);
      this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.Button btnStartQuadris;
    private System.Windows.Forms.Label lblQuadrisLogo;
    private System.Windows.Forms.Button btnLeaderboardQuadris;
    private System.Windows.Forms.Button btnQuitQuadris;
    private System.Windows.Forms.Panel panelQuadrisMenu;
    private System.Windows.Forms.Panel panelTrollrisMenu;
    private System.Windows.Forms.Label lblTrollrisLogo;
    private System.Windows.Forms.Button btnQuitTrollris;
    private System.Windows.Forms.Button btnLeaderboardTrollris;
    private System.Windows.Forms.Button btnStartTrollris;
    private System.Windows.Forms.Button btnSwitchToTrollris;
    private System.Windows.Forms.Button btnSwitchToQuadris;
  }
}