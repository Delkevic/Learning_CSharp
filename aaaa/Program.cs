using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace aaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            musteri m1 = new musteri();
            Console.WriteLine("Kimlik nonuzu giriniz: ");
            string TCNO = Console.ReadLine();
            m1.TC = TCNO;
            Console.WriteLine("TC : {0}",m1.TC);
            Console.ReadLine();
        }
    }
}
