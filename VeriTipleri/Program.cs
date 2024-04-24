using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Toplama Operatörü : +
            // Çıkarma Operatörü : -

            int sayi1 = 5;

            int sayi2 = 12;

            int sayi3 = 32;

            int sayi4 = 18;


            int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            Console.WriteLine(sonuc);


            // Çarpma Operatörü : *
            // Bölme Operatörü : /

            int sayii = 7;

            int sayii2 = 14;

            int sonuc1 = sayii / sayii2;

            int sonuc2 = sayii * sayii2;

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);

            // Mod Alma Operatörü = %

            int sayi = 10;

            int sayii1= 3;

            Console.WriteLine(sayi % sayii1);


            // Arttırma Operatörü : ++
            // Azaltma Opratörü : --

            int sayiii = 20;

            sayiii--;
            
            Console.WriteLine(sayiii);


            // Atama Operatörü : =

            int yas = 22;


            // Eşitir Operatörü : ==

            int sayi_1 = 4;

            int sayi_2 = 5;


            bool kontrolEt = sayi_1 == sayi_2;

            Console.WriteLine(kontrolEt);


            // Eşit Değildir Operatörü : !=

            int sayii_1 = 6;

            int sayii_2 = 7;


            bool KontrolEt = sayii_1 != sayii_2;

            Console.WriteLine(kontrolEt);


            // Büyüktür Operatörü : >
            // Büyük ve Eşittir Operatörü : >=

            int yas1 = 18;


            bool Kontrolet = yas1 >= 18;

            Console.WriteLine(kontrolEt);


            // Küçüktür Operatörü : <
            // Küçük Eşit Operatörü :<=

            int yas2 = 19;


            bool sonuc_1 = yas2 <= 19;

            Console.WriteLine(kontrolEt);


            // && ve Operatörü Shift+6

            int sayi_3 = 5;

            int sayi_4 = 5;

            int sayi_5 = 10;


            bool Kontrol_Et = sayi_3 == sayi_4 && sayi_3 < sayi_5;

            Console.WriteLine(Kontrol_Et);

            Console.ReadLine();
        }
    }
}
