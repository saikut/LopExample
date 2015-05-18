using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 20;
            //while (num < 25)
            //{
            //    Console.WriteLine("less than 25");
            //    num += 1;
            //}
            //Console.ReadKey();


            //do
            //{
            //    Console.WriteLine("less than 25");
            //    num += 1;
            //} while (num>25);
            //Console.ReadKey();


            //for (int i = 0; i < 4; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();


            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
               
                sum += i;
               

            }
            Console.WriteLine("Total : {0}", sum);
            Console.ReadKey();
        }
    }
}
