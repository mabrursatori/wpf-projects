using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo");
        }
    }

    public class Sales
    {
        public int ID { get; set; }
        public DateTime TanggalBeli { get; set; }
        public List<SalesItem> Items { get; private set; }

        public Sales(int newid)
        {
            this.ID = newid;
            TanggalBeli = DateTime.Now;
            Items = new List<SalesItem>();
        }

        public bool AddItem(string name, int jumlah)
        {
            SalesItem itemBaru = new SalesItem() { Nama = name, Jumlah = jumlah };
            if (!Items.Contains(itemBaru))
            {
                Items.Add(itemBaru);
                Console.WriteLine(itemBaru.Nama + " telah ditambahkan");
                return true;
            }
            else
            {
                Console.WriteLine(itemBaru.Nama + " telah ditambahkan sebelumnya");
                return false;
            }
        }
        public bool RemoveItem(SalesItem item)
        {
            if (!Items.Contains(item))
            {
                Console.WriteLine("Item tidak ditemukan");
                return false;
            }
            Items.Remove(item);
            Console.WriteLine(item.Nama + " telah diremove");
            return true;
        }
        public bool RemoveLast()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("Tak ada item");
                return false;
            }
            Console.WriteLine(Items[Items.Count - 1].Nama + " telah diremove");
            Items.RemoveAt(Items.Count - 1);
            return true;
        }
        public void ShowItems()
        {
            Console.WriteLine("------- Daftar Item ----------");
            foreach (SalesItem i in Items)
            {
                Console.WriteLine(i.Nama + ": " + i.Jumlah);
            }
            Console.WriteLine("--------------------------------");
        }

        public class SalesItem
        {
            public string Nama { get; set; }
            public int Jumlah { get; set; }

            //Digunakan untuk Contains dan Remove, untuk membandingkan objek
            public override bool Equals(object obj)
            {
                //Dengan var, C# akan otomatis mengetahui bahwa Other adalah SalesItem
                var Banding = obj as SalesItem;
                if (Banding.Nama == this.Nama) return true;
                return false;
            }
        }
    }
    }
