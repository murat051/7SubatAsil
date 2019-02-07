using MusteriIslem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriIslem.Ogrenci ogrenci = new MusteriIslem.Ogrenci("mustafa", 1234);
            Console.WriteLine(ogrenci.OgrenciNumara);
            Console.WriteLine(ogrenci.OgrenciIsmi);
            Console.WriteLine("---------------------");
            Ogrenci ogrenci2 = new Ogrenci("mehmet", 323);
            Console.WriteLine(ogrenci2.OgrenciNumara);
            Console.WriteLine(ogrenci2.OgrenciIsmi);

            // Object Interacion // nesneler arası iletişim
            ogrenci2.OgrenciIsmi = ogrenci.OgrenciIsmi;
            Console.WriteLine("---------------");
            Console.WriteLine(ogrenci2.OgrenciIsmi);

        }
    }
}
