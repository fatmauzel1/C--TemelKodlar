using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATMProjesi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcıya soracağız nasıl bir işlem yapmak istediğini
            // 1- Bakiye Görüntüleme 
            // 2- Para Çekme
            // 3- Para Yatırma
            // q ya basarsa çıkış yaptıracağız.


            int bakiye = 1000;

            Console.WriteLine("Atm ye Hoşgeldiniz");
            Console.WriteLine("Yapmak İstediğiniz İşlemi Seçiniz");
            string secim = Console.ReadLine();

            if (secim =="1")
            {
                Console.WriteLine("Mevcut Bakiyeniz :" + bakiye);
                Console.ReadLine();
            }
            else if (secim =="2") 
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if(cekilecek_tutar <bakiye)
                {

                Console.WriteLine("Kalan Tutar :" +( bakiye-cekilecek_tutar));
                Console.ReadLine() ;
                }
                else
                {
                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                    Console.ReadLine();
                }
            }
            else if (secim =="3")
            {
                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni Bakiyeniz :" + (bakiye + yatırılacak_tutar));
                Console.ReadLine() ;
            }
            else if (secim =="q") 
            {
                Console.WriteLine("Atm den Çıkış Yapılıyor");
                Console.WriteLine("Çıkış Yapıldı İyi Günler...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli Bir Değer Giriniz");
                Console.ReadLine();
            }

        }

    }
}
