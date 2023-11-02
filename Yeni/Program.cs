using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
        Yenidensecim:
            m.menu();
            string secim = Console.ReadLine();
            Console.Write("Lutfen ilk sayiyi giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("Lutfen ikinci sayiyi giriniz: ");
            int sayi2 = int.Parse(Console.ReadLine());
            decimal sonuc = 0;
            switch (secim)
            {
                case "1":
                    sonuc = m.toplama(sayi1, sayi2);
                    Console.WriteLine(sonuc);
                    break;
                case "2":
                    m.cikartma(sayi1, sayi2);
                    sonuc = m.cikartma(sayi1, sayi2);
                    Console.WriteLine(sonuc);
                    break;
                case "3":
                    m.carpma(sayi1, sayi2);
                    sonuc = m.carpma(sayi1, sayi2);
                    Console.WriteLine(sonuc);
                    break;
                case "4":
                    sonuc = m.bolme(sayi1, sayi2);
                    Console.WriteLine(sonuc);
                    break;
                default:
                    break;
            }
            Console.Write("Tekrar islem yapmak istiyor musunuz? (E/H)");
            string karar = Console.ReadLine();
            if (karar.ToUpper() == "E")
                goto Yenidensecim;
            Console.ReadLine();
        }

    }
}
