using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaa
{
    internal class musteri
    {
        private string tc;
        public string TC
        {
            get { return tc.Substring(0, 3); }
            set
            {
                if(value.Length == 11)
                {
                    bool kont = false;
                    for(int i = 0; i < value.Length; i++)
                    {
                        bool a = char.IsNumber(value[i]);
                        if (!a)
                        {
                            kont = true;
                            break;
                        }
                    }
                    if (kont)
                    {
                        Console.WriteLine("Kimlik nonuzda harf bulunamaz!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                    else { this.tc = value; }
                }
                else
                {
                    Console.WriteLine("Kimlik nonuz 11 haneli olmali.");
                    Console.ReadLine();
                }
            }
        }
    }
}
