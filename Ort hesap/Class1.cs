using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ort_hesap
{
    internal class ort
    {
        public void hesap(string isim, string soy, decimal not1, decimal not2, decimal not3)
        {
            decimal ortalama = (not1+not2+not3)/3;
            if (ortalama>45)
                Console.WriteLine("Tebrikler {0} {1}. Dersi {2} ortalama ile gectiniz.",isim,soy,ortalama);
            else
                Console.WriteLine("Sayin {0} {1}. Dersten {2} ortalama ile kaldiniz",isim,soy,ortalama);
        }
    }
}
