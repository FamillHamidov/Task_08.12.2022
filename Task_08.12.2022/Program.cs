using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08._12._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(string.Join(",", arr));
            Console.ReadKey();

            //---------------------------------------
            //Task 2

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Ededi daxil edin: ");
            int a = Convert.ToInt16(Console.ReadLine());
            /*IndexOf metodu eger daxil edilen eded arrayda varsa 
             o ededin yerlesdiyi indexi qaytarir, eded yoxdursa geriye
             -1 qaytarir*/ 
            int b=Array.IndexOf(array, a);
            if (b!=-1 && a== array[b])
            {
                Console.WriteLine("Eded arrayda var ");
            }
            else
            {
                Console.WriteLine("Yoxdur");
            }
            Console.ReadKey();
        }
    }
}
