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
namespace Latihan_Pos.Registration
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
            parameters.Add("nama", txtNama.Text);
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
    }
}
