using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indeksNumarasi
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string[] sehirler = { "Eskisehir", "Istanbul", "Ankara", "Izmir", "Diyarbakir", "Sinop" };
            Console.WriteLine("Bir şehir giriniz:");
            string girilenSehir = Console.ReadLine();
            bool varMi = false;

            for (i = 0; i < sehirler.Length+1; i++)
            {
                if (girilenSehir == sehirler[i])
                {
                    varMi = true;
                    break;
                }
                    
                else
                    continue;
            }
            if (varMi)
            {
                Console.WriteLine($"{girilenSehir} array'de var ve indeks numarası {i+1}.");
            }
            else
            {
                Console.WriteLine($"{girilenSehir} array'de yok.");
            }
            Console.ReadKey();
        }
    }
}
