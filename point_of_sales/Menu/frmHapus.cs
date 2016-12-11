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
using Latihan_Pos.CustomForm;
namespace Latihan_Pos.Menu
{
    public partial class frmHapus : MetroForm
    {
        public frmHapus()
        {
            InitializeComponent();
        }

        private void btnBrowseBarang_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("barang");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                txtIdBarang.Text = datas["id"];
                txtKode.Text = datas["kode"];
                txtNamaBarang.Text = datas["nama"];
                txtJumlahAwal.Text = datas["jumlah"];
                txtHargaHpp.Text = datas["harga_hpp"];
                txtHargaJual.Text = datas["harga_jual"];
            }
        }

        private void btnHapusBarang_Click(object sender, EventArgs e)
        {
            Database.DeleteData("tugas_pos.barang", Convert.ToInt32(txtIdBarang.Text));
            foreach (Control ctrl in mtpBarang.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";   
                }
            }
            MessageBox.Show("Barang berhasil dihapus.");
        }

        private void btnBrowseCustomer_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("customer");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                txtIdCustomer.Text = datas["id"];
                txtNamaCustomer.Text = datas["nama"];
                txtAlamatCustomer.Text = datas["alamat"];
                txtTeleponCustomer.Text = datas["nomor_telepon"];
            }
        }

        private void btnHapusCustomer_Click(object sender, EventArgs e)
        {
            Database.DeleteData("tugas_pos.customer", Convert.ToInt32(txtIdCustomer.Text));
            foreach (Control ctrl in mtpCustomer.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            MessageBox.Show("Customer berhasil dihapus.");
        }

        private void btnBrowseSupplier_Click(object sender, EventArgs e)
        {
            frmBrowse browse = new frmBrowse("supplier");
            browse.ShowDialog();
            Dictionary<string, string> datas = browse.getData();

            if (datas.Count > 0)
            {
                txtIdSupplier.Text = datas["id"];
                txtNamaSupplier.Text = datas["nama"];
                txtAlamatSupplier.Text = datas["alamat"];
                txtTeleponSupplier.Text = datas["nomor_telepon"];
            }
        }

        private void btnHapusSupplier_Click(object sender, EventArgs e)
        {
            Database.DeleteData("tugas_pos.supplier", Convert.ToInt32(txtIdSupplier.Text));
            foreach (Control ctrl in mtpSupplier.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            MessageBox.Show("Supplier berhasil dihapus.");
        }
    }
}
