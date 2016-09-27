using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtRange.Text = (vsbMinimum.Maximum - vsbMinimum.Value).ToString() + " -> " +
                            (vsbMinimum.Maximum - vsbMaximum.Value).ToString();
        }

        private void vsbMaximum_Scroll(object sender, ScrollEventArgs e)
        {
            if (vsbMaximum.Value > vsbMinimum.Value)
            {
                vsbMinimum.Value = vsbMaximum.Value;
            }
            txtRange.Text = (vsbMinimum.Maximum - vsbMinimum.Value).ToString() + " -> " + 
                            (vsbMinimum.Maximum - vsbMaximum.Value).ToString();
        }

        private void vsbMinimum_Scroll(object sender, ScrollEventArgs e)
        {
            if (vsbMaximum.Value > vsbMinimum.Value)
            {
                vsbMaximum.Value = vsbMinimum.Value;
            }
            txtRange.Text = (vsbMinimum.Maximum - vsbMinimum.Value).ToString() + " -> " +
                            (vsbMinimum.Maximum - vsbMaximum.Value).ToString();
        }

    }
}
