using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ort_hesap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ort ort = new ort();
            Console.Write("Ogrencinin ismini giriniz: ");
            string isim = Console.ReadLine();
            Console.Write("Ogrencinin soyadini giriniz: ");
            string soy = Console.ReadLine();
            Console.Write("1. notu giriniz: ");
            decimal not1 = decimal.Parse(Console.ReadLine());
            Console.Write("2. notu giriniz: ");
            decimal not2 = decimal.Parse(Console.ReadLine());
            Console.Write("3. notu giriniz: ");
            decimal not3 = decimal.Parse(Console.ReadLine());
            ort.hesap(isim, soy, not1, not2, not3);
            Console.ReadLine();
        }
    }
}
