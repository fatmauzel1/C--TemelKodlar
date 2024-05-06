using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_ve_Continue_Anahtar_Kelimeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            // Break anahtar kelimesi
            // Continue anahtar kelimesi 

            for (int a = 1; a<=10; a++)
            {
                if (a == 7)
                {
                    break;
                }
                Console.WriteLine("a'nın değeri :"+a);
            }


            for (int i = 1; i<=10; i++)
            {
                if(i == 5)
                {
                    continue;
                }
                Console.WriteLine("i'nın değeri :" + i);
            }
             Console.ReadLine();

        }   
    }
}
