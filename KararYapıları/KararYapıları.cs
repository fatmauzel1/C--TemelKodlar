using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Öğrencinin notu 50 den büyükse geçti değilse kaldı yazdır.

            int not = 90;

            if (not>50)
            {
                Console.WriteLine("Geçti");
                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("Kaldı");
                Console.ReadLine();



                // Koşul Yapısı

                //Kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve ortalaması
                //Eğer 80- 100 arasındaysa A+ yazdıran
                // 60 -80 arasındaysa A yazdıran 
                // 40- 60 arasındaysa B+ yazdıran
                // 40 dan küçükse F yazdıran örneğin kod parçalarını yazınız.

             
                Console.WriteLine("Lütfen 1. Notunuzu Giriniz");
                Console.ReadLine() ;

                int birinci_not = Convert.ToInt32(Console.ReadLine());

                int ikinci_not = Convert.ToInt32(Console.ReadLine());

                int ucuncu_not = Convert.ToInt32(Console.ReadLine());

                int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;
                

                if (sonuc > 80 && sonuc < 100)
                {
                    Console.WriteLine("Not Değeriniz : A+");
                    Console.ReadLine() ;
                }

                else if (sonuc > 60 && sonuc < 80)
                {
                    Console.WriteLine("Not Değeriniz : A");
                    Console.ReadLine();
                }
                
                else if (sonuc > 40 && sonuc < 60)
                {
                    Console.WriteLine("Not Değeriniz : B+");
                    Console.ReadLine();
                }
                
                else
                {
                    Console.WriteLine("Not Değeriniz F dir");
                    Console.ReadLine();
                }
                      
                

            }
        }
    }
}
