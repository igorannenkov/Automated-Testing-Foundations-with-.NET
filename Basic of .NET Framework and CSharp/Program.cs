using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_of.NET_Framework_and_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int basis;
            int index;
            string values = "0123456789ABCDEFGHIJ";
            string result = string.Empty;

            Console.Write("Введите число в 10-чной системе счисления: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите основание новой системы счисления (от 2 до 20): ");
            basis = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                index = number % basis;
                number = number / basis;
                result = values[index] + result;
            }

            Console.Write($"Ваше число в {basis}-чной системе счисления: {result}");
            Console.ReadKey();
        }
    }
}
