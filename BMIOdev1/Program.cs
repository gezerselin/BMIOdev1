using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("               Hoşgeldiniz");
            Console.WriteLine("------Beden Kitle İndeksi Hesaplayıcı------");
            Console.WriteLine();
            Console.WriteLine("Lütfen kilonuzu giriniz (kg cinsinden örnek : 48,2)");
            double kilo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu giriniz (m cinsinden örnek 1,58)");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bmi = kilo / (boy * boy);
            Console.WriteLine($"Beden kitle indeksiniz: { bmi} ");

            if (bmi < 19)
            {
                Console.WriteLine("Sonuc: Zayıf");
            }
            else if (bmi < 25)
            {
                Console.WriteLine("Sonuc: Normal");
            }
            else if (bmi < 30)
            {
                Console.WriteLine("Sonuc: Hafif şişman");
            }
            else if (bmi < 35)
            {
                Console.WriteLine("Sonuc: Şişman");
            }
            else if (bmi < 45)
            {
                Console.WriteLine("Sonuc: Sağlık açısından önemli");
            }
            else if (bmi < 50)
            {
                Console.WriteLine("Sonuc: Aşırı şişman");
            }
            else
            {
                Console.WriteLine("Sonuc: Morbid(ölümcül) şişman");
            }


            Console.ReadLine();
        }
    }
}
