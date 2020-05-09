using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapilari_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sınav notlarını giriniz.\n1. Sınav Notu: ");
            double sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sınav Notu: ");
            double sinav2 = Convert.ToDouble(Console.ReadLine());
            double ortalama = (sinav1 + sinav2) / 2;
            if (ortalama >= 50)
            {
                Console.Write("Öğrencinin ortalaması; " + ortalama + "'dir.\nDersten başarıyla geçmiştir.");
            }
            else
            {
                Console.Write("Öğrencinin ortalaması; " + ortalama + "'dir.\nDersten geçememiştir.");
            }
            Console.ReadKey();
        }
    }
}
// 1. ve 2. sınav notları girilen öğrencinin ortalaması hesaplanarak, ortalaması 50'den büyük veya eşitse geçti mesajı, küçük ise kaldı mesajı veren program.