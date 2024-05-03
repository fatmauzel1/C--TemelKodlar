using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler_Loops_
{
    internal class Program
    {
        static void Main(string[] args)
        {



            for (int i = 1; i<=10; i++)
            {
                Console.WriteLine(i);
            }

            
            for (int a =0; a<=10; a=a+2) 
            {
                Console.WriteLine(a);
            }


            for (int b =0; b<=10; b++)
            {
                for (int j =1; j<=b; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine("");
            }


            int c = 1;

            while (c <= 10)
            {
                Console.WriteLine(c);
                c++;
            }


            int d = 100;

            while(d>=0)
            {
                Console.WriteLine(d);
                d -= 2; 
            }


            int e = 1;

            do
            {
                Console.WriteLine(e);
                e++;

            } while (e<=10);


            int f= 1;
            int toplam = 0;

            do
            {
                toplam += f;
                f++;
            } while (f <= 100);

            Console.WriteLine(" 1' den 100 'e kadar olan sayıların TOPLAMI:" + toplam);


            Console.ReadLine();
        }
    }
}
