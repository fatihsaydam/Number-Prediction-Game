using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140710Con_SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayarın rastgele tuttuğu bir sayıyı kullanıcının tahmin ederek bulabileceği bir uygulama.

            Random rastgele = new Random();
            int tutulan = rastgele.Next(100);
            int tahmin, sayac = 0;
            do
            {
                Console.Write("Tahmininiz :");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin < tutulan)
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                else if (tahmin > tutulan)
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                sayac++;
            } while (tahmin != tutulan);

            Console.Write("Tebrikler {0} kerede bildiniz", sayac);
            Console.ReadLine();
        }
    }
}
