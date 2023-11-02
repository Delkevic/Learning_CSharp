using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList A1 = new ArrayList();
            do
            {
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer ekle");
                Console.WriteLine("2 - Değer listele");
                Console.WriteLine("3 - Değer ara");
                Console.WriteLine("4 - Değer düzenle");
                Console.WriteLine("5 - Değer sil");
                Console.WriteLine("6 - Butun degerleri sil");
                Console.WriteLine("7 - Uygulamadan cikis");
                Console.Write("Seciniz: ");
                string secim = Console.ReadLine();
                if (secim == "7") break;
                switch (secim)
                {
                    case "1":
                        Console.Write("Degeri giriniz: ");
                        string deger = Console.ReadLine();
                        A1.Add(deger);
                        break;
                    case "2":
                        foreach (string i in A1) Console.WriteLine(i);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Aramak istediginiz degeri giriniz: ");
                        string arama = Console.ReadLine();
                        bool kontrol1 = A1.Contains(arama);
                        if (kontrol1 == true) 
                            Console.WriteLine("Deger bulunmaktadir.");
                        else 
                            Console.Write("Deger bulunmamaktadir. Girdiginiz degerin eklenmesini istiyor musunuz? E veya H diyiniz: ");
                            string bos = Console.ReadLine();
                        if (bos.ToUpper() == "E")
                            A1.Add(arama);
                        break;
                    case "4":
                        Console.Write("Duzenlemek istediginiz degeri giriniz: ");
                        string duzenleme = Console.ReadLine();
                        Console.Write("Girmek istediginiz degeri yaziniz: ");
                        string degisdeger = Console.ReadLine();
                        A1[A1.IndexOf(duzenleme)] = degisdeger;
                        break;
                    case "5":
                        Console.Write("Silmek istediginiz degeri giriniz: ");
                        string silmek = Console.ReadLine();
                        A1.Remove(silmek);
                        break;
                    case "6":
                        A1.Clear();
                        break;
                    default:
                        break;
                }
            Console.Clear();
            } while (true);
        }
    }
}
