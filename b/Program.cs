using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.TC = "18293846813";
            string a = m1.TC;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
