using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Produk
    {
        public string nama { get; set; }
        public int harga { get; set; }
        public string jenis { get; set; }
        public string deskripsi { get; set; }

        public Produk(string nama, int harga, string jenis, string deskripsi)
        {
            this.nama = nama;
            this.harga = harga;
            this.jenis = jenis;
            this.deskripsi = deskripsi;
        }


    }
}
