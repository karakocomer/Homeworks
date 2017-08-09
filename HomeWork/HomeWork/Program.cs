using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        { // Ömer Karakoç
            int maas, urun;
            Console.WriteLine("Maaşınızı giriniz");
            maas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ürettiğini ürün miktarını giriniz.");
            urun = Convert.ToInt32(Console.ReadLine());
            if (1 <= urun && urun <= 10)
            {
                Console.WriteLine("maaşınız" + (maas + (urun * 5)));

            }
            else
            {
                if (11 <= urun && urun <= 25)
                {
                    Console.WriteLine("maaşınız" + (maas + (urun * 11)));
                }
                else
                {
                    if (26 <= urun && urun <= 40)
                    {
                        Console.WriteLine("maaşınız" + (maas + (urun * 17)));
                    }
                    else
                    {
                        if (41 <= urun)
                        {
                            Console.WriteLine("maaşınız" + (maas + (urun * 30)));
                        }
                    }

                }
            }
            Console.ReadKey();

        }
    }
}
