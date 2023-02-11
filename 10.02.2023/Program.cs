using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PassportClass;
using ComparisonClass;

namespace _10._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passport obj = new Passport();

            //obj.Name = Console.ReadLine();
            //Console.WriteLine(obj.Name);
            //Console.ReadKey();

            Comparison test = new Comparison("3<=2");
            Console.WriteLine(test.GetResult());
            Console.ReadKey();
           

        }
    }
}
