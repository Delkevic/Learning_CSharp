using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_Blackjack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool n = true;
            Random random1 = new Random();
            int ben = random1.Next(2, 21);
            int rakip = random1.Next(2, 21);
            Console.WriteLine("Rakibin kartlarinin toplami: " + rakip);
            Console.WriteLine("Sizin kartlarinizin toplami: " + ben);
            while (rakip <= 16)
            {
                Random random3 = new Random();
                int a = random3.Next(1, 10);
                rakip += a;
            }
            while (ben < 21)
            {
                Console.Write("Kart cekmek istiyor musunuz? E veya H: ");
                string karar = Console.ReadLine();
                if (karar.ToUpper() == "E")
                {
                    if (n == true) Console.WriteLine("Rakibin toplami: {0} oldu.", rakip);
                    n = false;
                    Console.Clear();
                    Random rnd = new Random();
                    ben += rnd.Next(1, 10);
                    Console.WriteLine("Toplam sayiniz: {0} oldu.", ben); ;
                }
                else if (karar.ToUpper() == "H")
                    break;
            }
            Console.Clear();
            Console.WriteLine("Rakibin toplami: {0}", rakip);
            Console.WriteLine("Sizin toplaminiz: {0}", ben);
            if (ben > 21 && rakip > 21)
            {
                Console.WriteLine("Berabere!");
            }
            if (ben <= 21 && rakip <= 21)
            {
                if (ben > rakip)
                    Console.WriteLine("Tebrikler! Kazandiniz.");
                else if (ben < rakip)
                    Console.WriteLine("Rakip kazandi!");
                else
                    Console.WriteLine("Berabere!");
            }
            if (ben > 21 && rakip <= 21)
                Console.WriteLine("Rakip kazandi!");
            if (ben <= 21 && rakip > 21)
                Console.WriteLine("Tebrikler! Kazandiniz.");
            Console.ReadLine();
        }
    }
}
