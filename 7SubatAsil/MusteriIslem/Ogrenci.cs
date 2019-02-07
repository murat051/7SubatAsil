using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriIslem
{
    public class Ogrenci
    {
        public string OgrenciIsmi; //field

        public int OgrenciNumara { get; set; } //property. Örnek olsun diye property yaptık
        
        // constructor, nesne yaratıldığı anda çalışır, yapıcı metod

        public Ogrenci(string isim, int numara)
        {
            OgrenciIsmi = isim;
            OgrenciNumara = numara;
        }

        public Ogrenci()
        {

        }

    }
}
