namespace Latihan_Pos
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mtRegistrasi = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtRegistrasi
            // 
            this.mtRegistrasi.Location = new System.Drawing.Point(23, 63);
            this.mtRegistrasi.Name = "mtRegistrasi";
            this.mtRegistrasi.Size = new System.Drawing.Size(150, 150);
            this.mtRegistrasi.TabIndex = 0;
            this.mtRegistrasi.Text = "Registrasi";
            this.mtRegistrasi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRegistrasi.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRegistrasi.TileImage")));
            this.mtRegistrasi.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRegistrasi.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtRegistrasi.UseTileImage = true;
            this.mtRegistrasi.Click += new System.EventHandler(this.mtRegistrasi_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 489);
            this.Controls.Add(this.mtRegistrasi);
            this.Name = "frmMain";
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "Xanxiver P.O.S";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtRegistrasi;


    }
}

