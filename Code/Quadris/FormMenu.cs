using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
      listPanel[index].BringToFront();
    }

    private void btnStartQuadris_Click(object sender, EventArgs e) {
      FrmMain quadrisGameForm = new FrmMain();
      quadrisGameForm.Show();
      this.Hide();
    }

    private void btnSwitchToTrollris_Click(object sender, EventArgs e) {
      if (index < listPanel.Count - 1) {
        listPanel[++index].BringToFront();
      }
    }

    private void btnSwitchToQuadris_Click(object sender, EventArgs e) {
      if (index > 0) {
        listPanel[--index].BringToFront();
      }
    }

    private void btnLeaderboard_Click(object sender, EventArgs e) {

    }

    private void btnQuitQuadris_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void btnQuitTrollris_Click(object sender, EventArgs e) {
      this.Close();
    }
  }
}
