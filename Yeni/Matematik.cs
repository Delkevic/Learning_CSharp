using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni
{
    internal class Matematik
    {
        public decimal toplama(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 + sayi2;
            return sonuc;
        }
        public decimal cikartma(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 - sayi2;
            return sonuc;
        }
        public decimal carpma(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 * sayi2;
            return sonuc;
        }
        public decimal bolme(decimal sayi1, decimal sayi2)
        {
            decimal sonuc = sayi1 / sayi2;
            return sonuc;
        }
        public void menu()
        {
            Console.Clear();
            Console.WriteLine("Menuye hos geldiniz");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Cikarma");
            Console.WriteLine("3 - Carpma");
            Console.WriteLine("4 - Bolme");
            Console.Write("Giris yapiniz: ");
        }
    }
}
