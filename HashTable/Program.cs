using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable H1 = new Hashtable();
            do
            {
                Console.Clear();
                Console.Write("Ingilizce kelimeyi giriniz: ");
                string ing = Console.ReadLine();
                if (H1.ContainsKey(ing) == true)
                {
                    Console.WriteLine("Girdiginiz deger zaten {0} seklinde bulunmaktadir", H1[ing]);
                    Console.ReadLine();
                    continue;
                }
                Console.Write("Turkce karsiligini giriniz: ");
                string tr = Console.ReadLine();
                H1.Add(ing, tr);
                Console.WriteLine("Girdiginiz degerler basariyla eklenmistir.");
                Console.Write("Tekrardan veri girisi yapmak istiyor musunuz? (E/H): ");
                string tekrar = Console.ReadLine().ToUpper();
                if (tekrar == "H")
                    break;
            } while (true);
            Console.ReadLine();
        }
    }
}
