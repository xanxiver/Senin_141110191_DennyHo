using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sql = MySql.Data.MySqlClient;
using MetroFramework.Forms;
using Latihan_Pos.Class;
using Latihan_Pos.Registration;

namespace Latihan_Pos
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void mtRegistrasi_Click(object sender, EventArgs e)
        {
            frmRegistrasi registrasiForm = new frmRegistrasi();
            registrasiForm.ShowDialog();
            registrasiForm.Dispose();
        }
    }
}
