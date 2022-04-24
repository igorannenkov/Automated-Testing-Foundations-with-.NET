using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development_and_build_tools
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string data = Console.ReadLine();
            if (data != string.Empty)
            {
                int maxSequence = 1;
                int currentSequence = 1;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] != data[i + 1])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                Console.Write($"Макс. кол-во неодинаковых символов: {maxSequence}");
            }
            else Console.WriteLine("Введенная строка пуста!");
            Console.ReadKey();
        }
    }
}