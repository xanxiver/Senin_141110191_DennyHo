using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Pos.Class
{
    class Barang
    {
        private string nama_tabel = "barang";
        private int id;
        private string kode;
        private string nama;
        private int jumlah;
        private decimal harga_hpp;
        private decimal harga_jual;
        private DateTime created_at;
        private DateTime updated_at;

        public Barang()
        { }

        public int getId()
        {
            return this.id;
        }

        public string getKode()
        {
            return this.kode;
        }
        
        public Barang setKode(string kode)
        {
            this.kode = kode;
            return this;
        }

        public string getNama()
        {
            return this.nama;
        }

        public Barang setNama(string nama)
        {
            this.nama = nama;
            return this;
        }

        public int getJumlah()
        {
            return this.jumlah;
        }
        public Barang setJumlah(int jumlah)
        {
            this.jumlah = jumlah;
            return this;
        }

        public decimal getHargaHpp()
        {
            return this.harga_hpp;
        }

        public Barang setHargaHpp(decimal harga_hpp)
        {
            this.harga_hpp = harga_hpp;
            return this;
        }

        public decimal getHargaJual()
        {
            return this.harga_jual;
        }

        public Barang setHargaJual(decimal harga_jual)
        {
            this.harga_jual = harga_jual;
            return this;
        }

        public DateTime getCreatedAt()
        {
            return this.created_at;
        }

        public Barang setCreatedAt(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public DateTime getUpdatedAt()
        {
            return this.updated_at;
        }

        public Barang setUpdatedAt(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this;
        }
    }
}
