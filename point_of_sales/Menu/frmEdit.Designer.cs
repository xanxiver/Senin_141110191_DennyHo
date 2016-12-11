namespace Latihan_Pos.Menu
{
    partial class frmEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mtcEdit = new MetroFramework.Controls.MetroTabControl();
            this.mtpBarang = new MetroFramework.Controls.MetroTabPage();
            this.btnEditBarang = new MetroFramework.Controls.MetroButton();
            this.btnBrowseBarang = new MetroFramework.Controls.MetroButton();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtHargaHpp = new System.Windows.Forms.TextBox();
            this.txtHargaJual = new System.Windows.Forms.TextBox();
            this.txtJumlahAwal = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.mtpCustomer = new MetroFramework.Controls.MetroTabPage();
            this.btnBrowseCustomer = new MetroFramework.Controls.MetroButton();
            this.txtIdCustomer = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnEditCustomer = new MetroFramework.Controls.MetroButton();
            this.txtTeleponCustomer = new System.Windows.Forms.TextBox();
            this.txtAlamatCustomer = new System.Windows.Forms.TextBox();
            this.txtNamaCustomer = new System.Windows.Forms.TextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpSupplier = new MetroFramework.Controls.MetroTabPage();
            this.btnBrowseSupplier = new MetroFramework.Controls.MetroButton();
            this.txtIdSupplier = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnEditSupplier = new MetroFramework.Controls.MetroButton();
            this.txtTeleponSupplier = new System.Windows.Forms.TextBox();
            this.txtAlamatSupplier = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mtcEdit.SuspendLayout();
            this.mtpBarang.SuspendLayout();
            this.mtpCustomer.SuspendLayout();
            this.mtpSupplier.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcEdit
            // 
            this.mtcEdit.Controls.Add(this.mtpBarang);
            this.mtcEdit.Controls.Add(this.mtpCustomer);
            this.mtcEdit.Controls.Add(this.mtpSupplier);
            this.mtcEdit.Location = new System.Drawing.Point(24, 64);
            this.mtcEdit.Name = "mtcEdit";
            this.mtcEdit.SelectedIndex = 0;
            this.mtcEdit.Size = new System.Drawing.Size(551, 286);
            this.mtcEdit.TabIndex = 0;
            // 
            // mtpBarang
            // 
            this.mtpBarang.Controls.Add(this.btnEditBarang);
            this.mtpBarang.Controls.Add(this.btnBrowseBarang);
            this.mtpBarang.Controls.Add(this.txtIdBarang);
            this.mtpBarang.Controls.Add(this.metroLabel14);
            this.mtpBarang.Controls.Add(this.txtHargaHpp);
            this.mtpBarang.Controls.Add(this.txtHargaJual);
            this.mtpBarang.Controls.Add(this.txtJumlahAwal);
            this.mtpBarang.Controls.Add(this.txtNamaBarang);
            this.mtpBarang.Controls.Add(this.txtKode);
            this.mtpBarang.Controls.Add(this.metroLabel9);
            this.mtpBarang.Controls.Add(this.metroLabel10);
            this.mtpBarang.Controls.Add(this.metroLabel11);
            this.mtpBarang.Controls.Add(this.metroLabel12);
            this.mtpBarang.Controls.Add(this.metroLabel13);
            this.mtpBarang.HorizontalScrollbarBarColor = true;
            this.mtpBarang.Location = new System.Drawing.Point(4, 35);
            this.mtpBarang.Name = "mtpBarang";
            this.mtpBarang.Size = new System.Drawing.Size(543, 247);
            this.mtpBarang.TabIndex = 0;
            this.mtpBarang.Text = "Barang";
            this.mtpBarang.VerticalScrollbarBarColor = true;
            // 
            // btnEditBarang
            // 
            this.btnEditBarang.Location = new System.Drawing.Point(387, 215);
            this.btnEditBarang.Name = "btnEditBarang";
            this.btnEditBarang.Size = new System.Drawing.Size(75, 23);
            this.btnEditBarang.TabIndex = 26;
            this.btnEditBarang.Text = "Edit";
            this.btnEditBarang.Click += new System.EventHandler(this.btnEditBarang_Click);
            // 
            // btnBrowseBarang
            // 
            this.btnBrowseBarang.Location = new System.Drawing.Point(372, 26);
            this.btnBrowseBarang.Name = "btnBrowseBarang";
            this.btnBrowseBarang.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseBarang.TabIndex = 25;
            this.btnBrowseBarang.Text = "Browse";
            this.btnBrowseBarang.Click += new System.EventHandler(this.btnBrowseBarang_Click);
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Enabled = false;
            this.txtIdBarang.Location = new System.Drawing.Point(156, 26);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(210, 20);
            this.txtIdBarang.TabIndex = 24;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(119, 24);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(30, 25);
            this.metroLabel14.TabIndex = 23;
            this.metroLabel14.Text = "ID";
            // 
            // txtHargaHpp
            // 
            this.txtHargaHpp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHargaHpp.Location = new System.Drawing.Point(156, 156);
            this.txtHargaHpp.Name = "txtHargaHpp";
            this.txtHargaHpp.Size = new System.Drawing.Size(306, 20);
            this.txtHargaHpp.TabIndex = 21;
            // 
            // txtHargaJual
            // 
            this.txtHargaJual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHargaJual.Location = new System.Drawing.Point(156, 189);
            this.txtHargaJual.Name = "txtHargaJual";
            this.txtHargaJual.Size = new System.Drawing.Size(306, 20);
            this.txtHargaJual.TabIndex = 22;
            // 
            // txtJumlahAwal
            // 
            this.txtJumlahAwal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJumlahAwal.Location = new System.Drawing.Point(156, 124);
            this.txtJumlahAwal.Name = "txtJumlahAwal";
            this.txtJumlahAwal.Size = new System.Drawing.Size(306, 20);
            this.txtJumlahAwal.TabIndex = 20;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamaBarang.Location = new System.Drawing.Point(156, 95);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(306, 20);
            this.txtNamaBarang.TabIndex = 19;
            // 
            // txtKode
            // 
            this.txtKode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKode.Location = new System.Drawing.Point(156, 62);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(306, 20);
            this.txtKode.TabIndex = 18;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(95, 62);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 25);
            this.metroLabel9.TabIndex = 13;
            this.metroLabel9.Text = "Kode";
            // 
            // metroLabel10
            // 
            this.metroLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel10.Location = new System.Drawing.Point(89, 90);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 25);
            this.metroLabel10.TabIndex = 14;
            this.metroLabel10.Text = "Nama";
            // 
            // metroLabel11
            // 
            this.metroLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(54, 184);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(94, 25);
            this.metroLabel11.TabIndex = 15;
            this.metroLabel11.Text = "Harga Jual";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(48, 156);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(100, 25);
            this.metroLabel12.TabIndex = 17;
            this.metroLabel12.Text = "Harga Hpp";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(38, 123);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(110, 25);
            this.metroLabel13.TabIndex = 16;
            this.metroLabel13.Text = "Jumlah Awal";
            // 
            // mtpCustomer
            // 
            this.mtpCustomer.Controls.Add(this.btnBrowseCustomer);
            this.mtpCustomer.Controls.Add(this.txtIdCustomer);
            this.mtpCustomer.Controls.Add(this.metroLabel2);
            this.mtpCustomer.Controls.Add(this.btnEditCustomer);
            this.mtpCustomer.Controls.Add(this.txtTeleponCustomer);
            this.mtpCustomer.Controls.Add(this.txtAlamatCustomer);
            this.mtpCustomer.Controls.Add(this.txtNamaCustomer);
            this.mtpCustomer.Controls.Add(this.metroLabel8);
            this.mtpCustomer.Controls.Add(this.metroLabel7);
            this.mtpCustomer.Controls.Add(this.metroLabel1);
            this.mtpCustomer.HorizontalScrollbarBarColor = true;
            this.mtpCustomer.Location = new System.Drawing.Point(4, 35);
            this.mtpCustomer.Name = "mtpCustomer";
            this.mtpCustomer.Size = new System.Drawing.Size(543, 247);
            this.mtpCustomer.TabIndex = 1;
            this.mtpCustomer.Text = "Customer";
            this.mtpCustomer.VerticalScrollbarBarColor = true;
            // 
            // btnBrowseCustomer
            // 
            this.btnBrowseCustomer.Location = new System.Drawing.Point(389, 55);
            this.btnBrowseCustomer.Name = "btnBrowseCustomer";
            this.btnBrowseCustomer.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseCustomer.TabIndex = 18;
            this.btnBrowseCustomer.Text = "Browse";
            this.btnBrowseCustomer.Click += new System.EventHandler(this.btnBrowseCustomer_Click);
            // 
            // txtIdCustomer
            // 
            this.txtIdCustomer.Enabled = false;
            this.txtIdCustomer.Location = new System.Drawing.Point(173, 55);
            this.txtIdCustomer.Name = "txtIdCustomer";
            this.txtIdCustomer.Size = new System.Drawing.Size(210, 20);
            this.txtIdCustomer.TabIndex = 17;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(136, 55);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(30, 25);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "ID";
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(404, 203);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnEditCustomer.TabIndex = 15;
            this.btnEditCustomer.Text = "Edit";
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // txtTeleponCustomer
            // 
            this.txtTeleponCustomer.Location = new System.Drawing.Point(172, 177);
            this.txtTeleponCustomer.Name = "txtTeleponCustomer";
            this.txtTeleponCustomer.Size = new System.Drawing.Size(307, 20);
            this.txtTeleponCustomer.TabIndex = 14;
            // 
            // txtAlamatCustomer
            // 
            this.txtAlamatCustomer.Location = new System.Drawing.Point(172, 135);
            this.txtAlamatCustomer.Name = "txtAlamatCustomer";
            this.txtAlamatCustomer.Size = new System.Drawing.Size(307, 20);
            this.txtAlamatCustomer.TabIndex = 13;
            // 
            // txtNamaCustomer
            // 
            this.txtNamaCustomer.Location = new System.Drawing.Point(172, 93);
            this.txtNamaCustomer.Name = "txtNamaCustomer";
            this.txtNamaCustomer.Size = new System.Drawing.Size(307, 20);
            this.txtNamaCustomer.TabIndex = 12;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(64, 172);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(102, 25);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "No Telepon";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(98, 130);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(68, 25);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Alamat";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(107, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Nama";
            // 
            // mtpSupplier
            // 
            this.mtpSupplier.Controls.Add(this.btnBrowseSupplier);
            this.mtpSupplier.Controls.Add(this.txtIdSupplier);
            this.mtpSupplier.Controls.Add(this.metroLabel3);
            this.mtpSupplier.Controls.Add(this.btnEditSupplier);
            this.mtpSupplier.Controls.Add(this.txtTeleponSupplier);
            this.mtpSupplier.Controls.Add(this.txtAlamatSupplier);
            this.mtpSupplier.Controls.Add(this.txtNamaSupplier);
            this.mtpSupplier.Controls.Add(this.metroLabel4);
            this.mtpSupplier.Controls.Add(this.metroLabel5);
            this.mtpSupplier.Controls.Add(this.metroLabel6);
            this.mtpSupplier.HorizontalScrollbarBarColor = true;
            this.mtpSupplier.Location = new System.Drawing.Point(4, 35);
            this.mtpSupplier.Name = "mtpSupplier";
            this.mtpSupplier.Size = new System.Drawing.Size(543, 247);
            this.mtpSupplier.TabIndex = 2;
            this.mtpSupplier.Text = "Supplier";
            this.mtpSupplier.VerticalScrollbarBarColor = true;
            // 
            // btnBrowseSupplier
            // 
            this.btnBrowseSupplier.Location = new System.Drawing.Point(389, 38);
            this.btnBrowseSupplier.Name = "btnBrowseSupplier";
            this.btnBrowseSupplier.Size = new System.Drawing.Size(90, 23);
            this.btnBrowseSupplier.TabIndex = 28;
            this.btnBrowseSupplier.Text = "Browse";
            this.btnBrowseSupplier.Click += new System.EventHandler(this.btnBrowseSupplier_Click);
            // 
            // txtIdSupplier
            // 
            this.txtIdSupplier.Enabled = false;
            this.txtIdSupplier.Location = new System.Drawing.Point(173, 38);
            this.txtIdSupplier.Name = "txtIdSupplier";
            this.txtIdSupplier.Size = new System.Drawing.Size(210, 20);
            this.txtIdSupplier.TabIndex = 27;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(136, 38);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(30, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "ID";
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(404, 186);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(75, 23);
            this.btnEditSupplier.TabIndex = 25;
            this.btnEditSupplier.Text = "Edit";
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // txtTeleponSupplier
            // 
            this.txtTeleponSupplier.Location = new System.Drawing.Point(172, 160);
            this.txtTeleponSupplier.Name = "txtTeleponSupplier";
            this.txtTeleponSupplier.Size = new System.Drawing.Size(307, 20);
            this.txtTeleponSupplier.TabIndex = 24;
            // 
            // txtAlamatSupplier
            // 
            this.txtAlamatSupplier.Location = new System.Drawing.Point(172, 118);
            this.txtAlamatSupplier.Name = "txtAlamatSupplier";
            this.txtAlamatSupplier.Size = new System.Drawing.Size(307, 20);
            this.txtAlamatSupplier.TabIndex = 23;
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(172, 76);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(307, 20);
            this.txtNamaSupplier.TabIndex = 22;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(64, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(102, 25);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "No Telepon";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(98, 113);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 25);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Alamat";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(107, 71);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(59, 25);
            this.metroLabel6.TabIndex = 19;
            this.metroLabel6.Text = "Nama";
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 373);
            this.Controls.Add(this.mtcEdit);
            this.Name = "frmEdit";
            this.Resizable = false;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.mtcEdit.ResumeLayout(false);
            this.mtpBarang.ResumeLayout(false);
            this.mtpBarang.PerformLayout();
            this.mtpCustomer.ResumeLayout(false);
            this.mtpCustomer.PerformLayout();
            this.mtpSupplier.ResumeLayout(false);
            this.mtpSupplier.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcEdit;
        private MetroFramework.Controls.MetroTabPage mtpBarang;
        private MetroFramework.Controls.MetroTabPage mtpCustomer;
        private MetroFramework.Controls.MetroTabPage mtpSupplier;
        private MetroFramework.Controls.MetroButton btnBrowseCustomer;
        private System.Windows.Forms.TextBox txtIdCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnEditCustomer;
        private System.Windows.Forms.TextBox txtTeleponCustomer;
        private System.Windows.Forms.TextBox txtAlamatCustomer;
        private System.Windows.Forms.TextBox txtNamaCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBrowseSupplier;
        private System.Windows.Forms.TextBox txtIdSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnEditSupplier;
        private System.Windows.Forms.TextBox txtTeleponSupplier;
        private System.Windows.Forms.TextBox txtAlamatSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TextBox txtHargaHpp;
        private System.Windows.Forms.TextBox txtHargaJual;
        private System.Windows.Forms.TextBox txtJumlahAwal;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKode;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroButton btnBrowseBarang;
        private System.Windows.Forms.TextBox txtIdBarang;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroButton btnEditBarang;
    }
}