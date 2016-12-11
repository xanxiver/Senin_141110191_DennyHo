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
    public partial class frmEdit : MetroForm
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

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

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpCustomer.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            Dictionary<string, object> parameters = new Dictionary<string, object> { };
            parameters.Add("nama", txtNamaCustomer.Text);
            parameters.Add("alamat", txtAlamatCustomer.Text);
            parameters.Add("nomor_telepon", txtTeleponCustomer.Text);
            Database.UpdateData("tugas_pos.customer", parameters, Convert.ToInt32(txtIdCustomer.Text));
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

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpSupplier.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            Dictionary<string, object> parameters = new Dictionary<string, object> { };
            parameters.Add("nama", txtNamaSupplier.Text);
            parameters.Add("alamat", txtAlamatSupplier.Text);
            parameters.Add("nomor_telepon", txtTeleponSupplier.Text);
            Database.UpdateData("tugas_pos.supplier", parameters, Convert.ToInt32(txtIdSupplier.Text));
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

        private void btnEditBarang_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpBarang.Controls)
            {
                if (ctrl is TextBox && ctrl.Text.Trim() == "")
                {
                    MessageBox.Show("Data tidak boleh ada yang kosong.");
                    return;
                }
            }
            Dictionary<string, object> parameters = new Dictionary<string, object> { };
            parameters.Add("kode", txtKode.Text);
            parameters.Add("nama", txtNamaBarang.Text);
            parameters.Add("harga_hpp", Convert.ToDecimal(txtHargaHpp.Text));
            parameters.Add("harga_jual", Convert.ToDecimal(txtHargaJual.Text));
            parameters.Add("jumlah", Convert.ToInt32(txtJumlahAwal.Text));
            Database.UpdateData("tugas_pos.barang", parameters, Convert.ToInt32(txtIdBarang.Text));
        }
    }
}
