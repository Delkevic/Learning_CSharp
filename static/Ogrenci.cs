using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticd
{
    internal class Personel
    {
        public static string domain = "firma.com";
        public string isim { get; set; }
        public string soyisim { get; set; }
        public int cinsiyet { get; set; }

        private string email;
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value.ToLower() + "@" + Personel.domain;
            }
        }

    }
}
