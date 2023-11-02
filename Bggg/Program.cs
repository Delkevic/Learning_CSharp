using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bggg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yan yan = new Yan();
            decimal ort = 0;
            Console.Write("Ogrencinin ismini giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Ogrencinin soyismini giriniz: ");
            string soyisim = Console.ReadLine();
            Console.Write("1. notu giriniz: ");
            int not1 = int.Parse(Console.ReadLine());
            Console.Write("2. notu giriniz: ");
            int not2 = int.Parse(Console.ReadLine());
            Console.Write("3. notu giriniz: ");
            int not3 = int.Parse(Console.ReadLine());
            yan.not(isim,soyisim,not1,not2,not3);
            Console.ReadLine();
        }
    }
}
