using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcı giriş sayfası uygulaması 
            // Kullanıcı adı ve şifresini doğru girerse Tebrikler Başarılı Bir Şekilde Giriş Yaptınız
            // Yanlış girerse hata verelim ve 3 hak tanıyalım yanlış girdiği sürece döngü dönmeye devam etsin

             int hak_sayisi = 3;

            while(true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz");
                string sifre = Console.ReadLine();


                if (kullaniciAdi =="fatma" && sifre =="123")
                {
                    Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız:");
                    break;
                }

                else
                {
                    Console.WriteLine("kullanıcı adınız veya şifreniz yaanlış !");
                    
                    if (hak_sayisi > 0)
                    {
                        hak_sayisi -= 1;
                    }

                    if (hak_sayisi==0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur giriş yapamazsınız");
                        break;
                    }

                     
                }
                
            }

            Console.ReadLine();


        }   

            
    }
}
