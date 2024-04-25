using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Readline 

            Console.WriteLine("lütfen adınızı giriniz");

            string isim = Console.ReadLine();


            Console.WriteLine("Soyisminizi giriniz");

            string soyisim = Console.ReadLine();


            Console.WriteLine("Kullanıcının ismi" + isim);
            Console.WriteLine("Kullanıcının soyismi" + soyisim);
            


            Console.ReadLine();
        }
    }
}
