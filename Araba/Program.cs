using ArabaC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Araba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arac a1 = new Arac();
            Console.Write("aracin markasi nedir");
            a1.marka = Console.ReadLine();
            Console.Write("Aracin modeli nedir");
            a1.model = Console.ReadLine();
            Console.Write("aracin model yili nedir");
            a1.yil = Convert.ToInt32(Console.ReadLine());
            Console.Write("aracin kilometresi nedir");
            a1.km = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aracin yakit tipi nedir");
            a1.yakit_tipi = Console.ReadLine();
            Console.Write("Aracin vites tipi nedir");
            a1.vites = Console.ReadLine();
            Console.Write("Aracin alis fiyati nedir nedir");
            a1
        }
    }
}
