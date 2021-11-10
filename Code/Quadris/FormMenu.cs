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
    public FormMenu() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      FrmMain quadrisGameForm = new FrmMain();
      quadrisGameForm.Show();
      this.Hide();
    }

    private void lblQuadrisLogo_Click(object sender, EventArgs e) {

    }

    private void FormMenu_Load(object sender, EventArgs e) {
      this.Size = new Size(525, 500);
    }

    private void btnLeaderboard_Click(object sender, EventArgs e) {

    }
  }
}
