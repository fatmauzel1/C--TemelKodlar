﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayınınToplamınınOrtalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıdan bir sayı alacığız 0'dan başlayıp aldığımız sayıya kadar toplayacağız ve girdiği sayıyı
            // böleceğiz  eğer ortalama 50 'den büyükse ortalama 50'den büyüktür
            // değilse ortalama 50'den küçüktür yazdırsın.

            Console.WriteLine("Lütfen bir sayı giriniz...");

            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;  // toplam=toplam+i;
            }

            double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalamanız 50'den büyüktür...");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Ortalamanız 50 'den küçüktür...");
                Console.ReadLine() ;
            }

        }
    }
}
