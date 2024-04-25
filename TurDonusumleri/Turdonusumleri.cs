using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonuşumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //İNT VERİ TİPİNİ BYTE VERİ TİPİNE DÖNÜŞTÜRME

            int a = 5;

            byte b = (byte)a;

            Console.WriteLine(b.GetType());
            Console.WriteLine(b);


            //STRİNG VERİ TİPİNİ İNT VERİ TİPİNE DÖNÜŞTÜRME

            string sayi1 = "1";

            string sayi2 = "2";

            //int a = int.Parse(sayi1);

            //int b =int.Parse(sayi2);

            //Console.WriteLine(a + b);

            int c = Convert.ToInt32(sayi1);

            int d = Convert.ToInt32(sayi2);

            Console.WriteLine(c+d);


            //İNT VERİ TİPİNİ STRİNG VERİ TİPİNE DÖNÜŞTÜRME

            int sayi3 = 5;

            int sayi4 = 10;

            string f = sayi3.ToString();

            string g = sayi4.ToString();

            Console.WriteLine(f+g);


            // DOUBLE VERİ TİPİNİ İNT VERİ TİPİNE DÖNÜŞTÜRME

            double sayi5 = 5.22;

            int h = Convert.ToInt32(sayi5);

            // int l = int.Parse(sayi);

            Console.WriteLine(h);
            Console.WriteLine(sayi5.GetType());


            // KULLANICIDAN ALINAN DEĞERLER STRİNG VERİ TİPİNDE OLUR.


            Console.WriteLine("Lütfen Yaşınızı Giriniz");

            string kullanici_yas =Console.ReadLine();

            int kullanici_yasınt = int.Parse(kullanici_yas);

            int kullanici_yasınt2 = Convert.ToInt32(kullanici_yas);

            Console.WriteLine(kullanici_yasınt);
            Console.WriteLine(kullanici_yasınt2);

            // Kullanıcıdan 2 tane sayı alan ve ikisinin toplamını ekrana yazdıran programı yazınız.

            Console.WriteLine("Birinci Sayıyı Giriniz");

            string sayi6 = Console.ReadLine();

            Console.WriteLine("İkinci Sayıyı Giriniz");

            string sayi7 = Console.ReadLine();

            int sayi1ınt = int.Parse(sayi6);
            int sayi2ınt = int.Parse(sayi7);

            Console.WriteLine("İki Sayının Toplamı: " + ( sayi1ınt + sayi2ınt));



            Console.ReadLine();

        }
    }
}
