using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayiOyunu
{
    public class Bul : ITahmin
    {
        int tahmin = 0, sayac = 0;
        int hafiza;
        public void RandomSayi()
        {
            Random rast = new Random();
            hafiza = rast.Next(1, 100);
        }
        public void Degisken()
        {
            while (tahmin != hafiza)
            {
                sayac++;
                Console.WriteLine("1 ile 100 arasında sayı girin :");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > hafiza)
                {
                    Console.WriteLine("Daha küçük sayı giriniz.");

                }
                else if (tahmin < hafiza)
                {
                    Console.WriteLine("Daha büyük sayı giriniz.");

                }

            }
            Console.WriteLine("Doğru bildiniz!!!!");
            Console.WriteLine("[0].denemede bulundu.", sayac);
            Console.ReadLine();

        }
    }
}
