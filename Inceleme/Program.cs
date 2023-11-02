using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamben = 0;
            int toplamrakip = 0;
            int sayi1 = 0;
            int sayi2 = 0;
            int sayi3 = 0;
            int sayi4 = 0;
            int sayi5 = 0;
            int sayi6 = 0;
            Random random1 = new Random();
            sayi1 = random1.Next(1, 7);
            Random random2 = new Random();
            sayi2 = random1.Next(1, 7);
            Random random3 = new Random();
            sayi3 = random1.Next(1, 7);
            Random random4 = new Random();
            sayi4 = random1.Next(1, 7);
            Random random5 = new Random();
            sayi5 = random1.Next(1, 7);
            Random random6 = new Random();
            sayi6 = random1.Next(1, 7);
            toplamrakip = sayi1 + sayi2 + sayi3;
            toplamben = sayi4 + sayi5 + sayi6;
            Console.WriteLine("Rakibin toplam sayisi {0}", toplamrakip);
            Console.WriteLine("Sizin toplam sayiniz {0}", toplamben);
            while (true)
            {
                if (toplamrakip <= 15)
                {
                    int rnd = 0;
                    Random random10 = new Random();
                    rnd = random10.Next(1, 10);
                    toplamrakip += rnd;
                }
                else
                    break;
            }
            while (true)
            {
                if (toplamben < 21)
                {
                    Console.Write("Kart cekmek isterseniz 1 yazin, kalmak isterseniz 2 yazin.");
                    string kart = Console.ReadLine();
                    Console.Clear();
                    if (kart == "1")
                    {
                        int sayi7 = 0;
                        Random random7 = new Random();
                        sayi7 = random7.Next(1, 10);
                        toplamben += sayi7;
                        if (toplamben >= 21)
                            break;
                        Console.Write("Toplam sayiniz {1} oldu. Kart cekmek istiyorsaniz 1, kalmak istiyorsaniz 2 yaziniz: ", toplamrakip, toplamben);
                        string kart2 = Console.ReadLine();
                        Console.Clear();
                        if (toplamben >= 21)
                            break;
                        if (kart2 == "1")
                        {
                            int sayi8 = 0;
                            Random random8 = new Random();
                            sayi8 = random8.Next(1, 10);
                            toplamben += sayi8;
                            if (toplamben >= 21)
                                break;
                            Console.Write("Toplam sayiniz {0} oldu. Kart cekmek istiyorsaniz 1, kalmak istiyorsaniz 2 yaziniz:", toplamben);
                            string kart3 = Console.ReadLine();
                            Console.Clear();
                            if (kart3 == "1")
                            {
                                int sayi9 = 0;
                                Random random9 = new Random();
                                sayi9 = random9.Next(1, 10);
                                toplamben += sayi9;

                            }
                            break;
                        }
                        else
                            break;
                    }
                    else
                        break;
                }
                else
                    break;
            }
            Console.WriteLine("Sizin sayiniz {0}", toplamben);
            Console.WriteLine("Rakibin sayisi {0}", toplamrakip);
            if (toplamben <= 21 && toplamrakip <= 21)
            {
                if (toplamben < toplamrakip)
                {
                    Console.WriteLine("Uzgunum. Kaybettiniz.");
                }
                else if (toplamben == toplamrakip)
                {
                    Console.WriteLine("Berabere!");
                }
                else
                {
                    Console.WriteLine("Tebrikler! Kazandiniz.");
                }
            }
            if (toplamben > 21 && toplamrakip > 21)
            {
                Console.WriteLine("Berabere!");
            }
            else if (toplamben <= 21 && toplamrakip > 21)
            {
                Console.WriteLine("Tebrikler. Kazandiniz.");
            }
            else if (toplamben > 21 && toplamrakip <= 21)
            {
                Console.WriteLine("Kaybettiniz.");
            }
            Console.ReadLine();
        }
    }
}
