using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace task1
{
    class HashTable<T>
    {
        public ListNode<int>[] values;     //base public Array<ListNode<int>> values; Что имеллось ввиду Array<ListNode<int>>????? Array рассширять отдельно для типа?

        public HashTable(int size)
        {
            values = ListNode<int>[size];
        }

        public void Insert(int newValue)   //base
        {
            var k = GetHash(newValue);
            if (values)
            {

            }
            else
            {

            }
        }      
    }
}
