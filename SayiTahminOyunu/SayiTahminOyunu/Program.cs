using System;
using System.Linq;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ctrl + R M -> Extract Method
            // Ctrl + M O -> Close method content
            // Ctrl + M P -> Open method content

            //Aybars();

            //Omer();

            OmerHak();

            Console.ReadKey();
        }

        private static void OmerHak()
        {
            Random rnd = new Random();
            int sayac = 0;
            int sayitahmin = 0;
            int hak = 5;
            int sayibilgisayar = rnd.Next(0, 1);
            bool winStatus = false;
            do
            {
                sayac++;
                Console.WriteLine("sayı giriniz");
                sayitahmin = Convert.ToInt32(Console.ReadLine());           

                if (sayitahmin > sayibilgisayar)
                {
                    Console.WriteLine("Tekrar deneyiniz,sayı büyük");
                }
                else if((sayibilgisayar < sayitahmin))
                {
                    Console.WriteLine("Tekrar deneyiniz,sayı küçük");
                }
                else 
                {
                    Console.WriteLine("doğru tahmin ettiniz " + sayac + ".tahminde bildiniz.");
                    winStatus = true;
                }

                if (hak == 0)
                {
                    Console.WriteLine("hakkınız tükendi");
                    break;
                }

                if (winStatus != true)
                {
                    Console.WriteLine("kalan hak sayınız" + hak);
                    hak--;
                }

            } while (sayitahmin != sayibilgisayar);

        }

        private static void Omer()
        {
            Random rnd = new Random();
            int sayac = 0;
            int sayitahmin;
            int sayibilgisayar = rnd.Next(0, 11);
            Console.WriteLine("sayı giriniz");
            do
            {
                sayitahmin = Convert.ToInt32(Console.ReadLine());
                if (sayitahmin > sayibilgisayar)
                {
                    Console.WriteLine("Tekrar deneyiniz,sayı büyük");
                }
                else if (sayitahmin < sayibilgisayar)
                {
                    Console.WriteLine("Tekrar deneyiniz,sayı küçük");
                }
                sayac++;
            } while (sayitahmin != sayibilgisayar);
            Console.WriteLine("doğru tahmin ettiniz " + sayac + ".tahminde bildiniz.");
            Console.ReadKey();
        }

        private static void Aybars()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(1, 20);

            int guess = 0;
            int counter = 0;
            int hak = 5;

            while (guess != magicNumber)
            {
                Console.Write($"{counter + 1}. Tahmininizi giriniz : ");
                guess = Convert.ToInt32(Console.ReadLine());
                counter = counter + 1;

                if (guess == magicNumber)
                {
                    Console.WriteLine("BRAVO.");
                    break;
                }

                hak = hak - 1;
                if (hak == 0)
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                Console.WriteLine(guess > magicNumber ? "daha kucuk gir" : "daha buyuk gir");

                Console.WriteLine($"{hak} hakkiniz kaldi");
            }

            Console.ReadKey();
        }
    }
}