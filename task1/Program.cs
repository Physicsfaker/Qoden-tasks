using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1 //хэш-таблица
{
    /* Реализовать хэш-таблицу с функцией хэширования X % N, 
     * где X — целое число, помещаемоев хэш-таблицу, 
     * N — целое число, от деления на которое берётся остаток. 
     * Коллизии разрешаются с помощью односвязного списка.*/

    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens;

            tokens = Console.ReadLine().Split(' ');
            HashTable ht = new HashTable(Convert.ToInt32(tokens[0]));

            tokens = Console.ReadLine().Split(' ');
            foreach (string item in tokens)
            {
               ht.Insert(Convert.ToUInt32(item));
            }

            ht.ShowTable();
        }
    }
}
