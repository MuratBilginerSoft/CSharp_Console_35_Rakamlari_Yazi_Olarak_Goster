using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rakamlari_Yazi_Olarak_Göster
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] sayı = { "Sıfır", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz", "On" };
            char b='e';

            do
            {
                Console.Write("Bir sayı Giriniz (0-10)=");
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\n"+a+"="+sayı[a]);

                Console.WriteLine("\nDevam Etmek İstiyormusunuz? [E/H]");
                b = char.Parse(Console.ReadLine());

            } while (b == 'e' || b== 'E');

            Console.ReadKey();




        }
    }
}
