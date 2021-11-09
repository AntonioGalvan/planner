using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planner
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void pbxAdd_Click(object sender, EventArgs e)
        {

        }

        private void pbxView_Click(object sender, EventArgs e)
        {
            new frmPlanner().Show();
            this.Hide();
        }

        private void pnlExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
