﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quadris {
  public partial class FormMenu : Form {
    List<Panel> listPanel = new List<Panel>();
    
    int index = 0;

    public FormMenu() {
      InitializeComponent();
    }

    private void FormMenu_Load(object sender, EventArgs e) {
      this.Size = new Size(425, 345);
      listPanel.Add(panelQuadrisMenu);
      listPanel.Add(panelTrollrisMenu);
      panelQuadrisMenu.Visible = true;
      panelTrollrisMenu.Visible = true;
      panelLeaderboard.Visible = true;
      updateLeaderboard();
    }

    //Function that starts a game of quadris
    private void btnStartQuadris_Click(object sender, EventArgs e) {
      FrmMain quadrisGameForm = new FrmMain();
      quadrisGameForm.Show();
      this.Hide();
    }

    //Function that starts a game of trollris
    private void btnStartTrollris_Click(object sender, EventArgs e) {
      FrmMainTrollris trollrisGameForm = new FrmMainTrollris();
      trollrisGameForm.Show();
      this.Hide();
    }

    //Function that swaps to the trollris menu
    private void btnSwitchToTrollris_Click(object sender, EventArgs e) {
      if (index < listPanel.Count - 1) {
        listPanel[++index].BringToFront();
      }
    }

    //Function that swaps to the quadris menu
    private void btnSwitchToQuadris_Click(object sender, EventArgs e) {
      if (index > 0) {
        listPanel[--index].BringToFront();
      }
    }

    //Function that displays the leaderboard
    private void btnLeaderboard_Click(object sender, EventArgs e) {
      panelLeaderboard.BringToFront();
    }

    private void btnQuitQuadris_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void btnQuitTrollris_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void btnBackToMenu_Click(object sender, EventArgs e) {
      listPanel[index].BringToFront();
    }

    private void btnLeaderboardTrollris_Click(object sender, EventArgs e) {
      panelLeaderboard.BringToFront();
    }

    //Function that updates the scores on the leaderboard
    private void updateLeaderboard() {
      try {
        string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                
        while(dir.Substring(dir.Length - "Quadris".Length) != "Quadris") {
          dir = dir.Remove(dir.Length - 1,1);
        }

        string path = dir + "\\HighScore.txt";

        List<Label> Scores = new List<Label>();
        Scores.Add(lblLeaderScore1);
        Scores.Add(lblLeaderScore2);
        Scores.Add(lblLeaderScore3);
        Scores.Add(lblLeaderScore4);
        Scores.Add(lblLeaderScore5);
        Scores.Add(lblTrollrisScore1);
        Scores.Add(lblTrollrisScore2);
        Scores.Add(lblTrollrisScore3);
        Scores.Add(lblTrollrisScore4);
        Scores.Add(lblTrollrisScore5);

        if (!File.Exists(path)) {
          // Create a file to write to.
          using (StreamWriter sw = File.CreateText(path)) {
            for (int x = 0; x < 10; x++) {
              sw.WriteLine("0000");
            }
          }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path)) {
          String newScore;
          for (int x = 0; x < 10; x++) {
            newScore = sr.ReadLine();
            Scores[x].Text = newScore;
          }
        }
      }
      catch (Exception e) { }
    }
  }
}
