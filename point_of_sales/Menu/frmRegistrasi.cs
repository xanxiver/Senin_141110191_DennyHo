using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Latihan_Pos.Class;
namespace Latihan_Pos.Menu
{
    public partial class frmRegistrasi : MetroForm
    {
        public frmRegistrasi()
        {
            InitializeComponent();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in mtpBarang.Controls)
            {
                if (ctrl is TextBox && ctrl.Name != "txtId" && ctrl.Text.Trim() == "")
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
            try 
	        {
                Database.InsertData("tugas_pos.barang", parameters);
	        }
	        catch (Exception ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
        }

        private void btnSimpanCustomer_Click_1(object sender, EventArgs e)
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
            try
            {
                Database.InsertData("tugas_pos.customer", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void mtpSimpanCustomer_Click(object sender, EventArgs e)
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
            try
            {
                Database.InsertData("tugas_pos.customer", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSimpanSupplier_Click(object sender, EventArgs e)
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
            try
            {
                Database.InsertData("tugas_pos.supplier", parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRegistrasi_Load(object sender, EventArgs e)
        {
            mtcRegistrasi.SelectTab(0);
        }

    }
}
