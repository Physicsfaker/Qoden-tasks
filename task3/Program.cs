using System;
using System.Collections.Generic;

/* Простейший калькулятор
 * операторы: + (сложение), - (вычитание), * (умножение), / (деление).
 * Операторы и числа во входной последовательности отделены друг от друга пробелом.
 * Входная последовательность операторов и чисел гарантированно даёт целый результат.
 */
namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens;
            Stack<int> numbers = new Stack<int>();

            tokens = Console.ReadLine().Split(' ');

            foreach (string item in tokens)
            {
                if (numbers.Count < 2)
                {
                    numbers.Push(Convert.ToInt32(item));
                }
                else
                {
                    int x; int y;

                    switch (item)
                    {
                        case "+": y = numbers.Pop(); x = numbers.Pop(); numbers.Push(x + y); break;
                        case "-": y = numbers.Pop(); x = numbers.Pop(); numbers.Push(x - y); break;
                        case "*": y = numbers.Pop(); x = numbers.Pop(); numbers.Push(x * y); break;
                        case "/": y = numbers.Pop(); x = numbers.Pop(); numbers.Push(x / y); break;
                        default: numbers.Push(Convert.ToInt32(item)); break;
                    }
                }
            }

            Console.WriteLine(numbers.Peek());
        }
    }
}
