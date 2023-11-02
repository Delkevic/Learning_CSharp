using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bggg
{
    internal class Yan
    {
        
        public void not(string isim, string soyisim,decimal not1, decimal not2, decimal not3)
        {
            decimal ort = (not1 + not2 + not3)/3;
            if (ort < 45)
            {
                Console.WriteLine("{0} {1} isimli ogrencinin aldigi ortlama: {2}. 45 in altinda oldugu icin ogrenci kalmistir.", isim, soyisim, ort);
            }
            else
                Console.WriteLine("{0} {1} isimli ogrencinin aldigi ortlama: {2}. 45 in uzerinde veya esit oldugu icin ogrenci gecmistir.", isim, soyisim, ort);
        }
    }
}
