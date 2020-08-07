using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step1

            //int num = Convert.ToInt32("45");

            //Console.WriteLine(num + 6);

            //Console.ReadLine();

            //Step2 decimals

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            // double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);
            //Console.ReadLine();

            //Step3 intergers

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);
            Console.ReadLine();


        }
    }
}
