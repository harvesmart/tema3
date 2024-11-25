using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyMethods
    {
        public void PrintMessage()
        {
            Console.WriteLine("Акууууна матата");
        }

        public void DisplayDate()
        {
            Console.WriteLine($"Сегодняшняя дата: {DateTime.Now.ToShortDateString()}");
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public string GetGreeting(string name)
        {
            return $"Привет, {name}";
        }
    }
}
