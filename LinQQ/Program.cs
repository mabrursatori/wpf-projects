using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Mahasiswa> Mhs = new List<Mahasiswa>() {
      new Mahasiswa("Fandi", "Fisika", 2001),
      new Mahasiswa("Agung", "Fisika", 2001),
      new Mahasiswa("Jon", "Fisika", 2000),
      new Mahasiswa("Arthur", "Fisika", 2000),
      new Mahasiswa("Hendera", "Kimia", 2001),
      new Mahasiswa("Kurniawan", "Kimia", 2001),
    };

            Console.WriteLine("Mahasiswa tahun 2001:");
            IEnumerable<Mahasiswa> tahun2001 = from m in Mhs where m.TahunMasuk == 2001 select m;
            foreach (Mahasiswa m in tahun2001)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("\nMahasiswa Fisika:");
            List<Mahasiswa> fisika = (from m in Mhs where m.Jurusan == "Fisika" select m).ToList();
            foreach (Mahasiswa m in fisika)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("\nMahasiswa Fisika tahun 2001:");
            IEnumerable<string> fisika2001 = from m in Mhs where m.Jurusan == "Fisika" && m.TahunMasuk == 2001 select m.Nama;
            foreach (string nama in fisika2001)
            {
                Console.WriteLine(nama);
            }

            Console.ReadKey();
        }
    }
    class Mahasiswa
    {
        public string Nama { get; set; }
        public string Jurusan { get; set; }
        public int TahunMasuk { get; set; }
        public Mahasiswa(string nama, string jurusan, int tahun)
        {
            this.Nama = nama;
            this.Jurusan = jurusan;
            this.TahunMasuk = tahun;
        }
        public override string ToString()
        {
            return "Nama   : " + Nama
              + "\nJurusan: " + Jurusan
              + "\nTahun  : " + TahunMasuk
              + "\n--------------------";
        }
    }
}
