using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethods methods = new MyMethods();

            methods.PrintMessage();
            methods.DisplayDate();

            int sum = methods.AddNumbers(13, 37);
            Console.WriteLine($"Сумма чисел: {sum}");

            string greeting = methods.GetGreeting("Андрей");
            Console.WriteLine(greeting);
        }
    }
}
