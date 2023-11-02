using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    internal class Musteri
    {
        private string tc;
        public string TC
        {
            get
            {
                return tc.Substring(0,3);
            }
            set
            {
                if (value.Length == 11)
                {
                    bool a = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool b = char.IsNumber(value[i]);
                        if (b)
                        {

                        }
                        else
                        {
                            a = true;
                            break;
                        }
                    }
                    if (a)
                    {
                        Console.Write("TC kimlik nonun icinde harf bulunamaz!");
                    }
                    else
                    {
                        this.tc = value;
                    }
                }
                else
                    Console.Write("TC kimlik 11 haneli olmali.");
            }
        }

    }
}
