using System;
using System.Collections.Generic;
using System.Collections;

namespace task1
{
    public class ListNode<T>
    {
        T value;
        ListNode<T> next;

        public void Insert(T newValue)
        {
            if (next == null)
            {
                next = new ListNode<T>(newValue);
            }
            else
            {
                next.Insert(newValue);
            }
        }

        public ListNode(T newValue)
        {
            value = newValue;
        }

        public void ShowValues()
        {
            if (next == null)
            {
                Console.Write($"{value} ");
            }
            else
            {
                Console.Write($"{value} ");
                next.ShowValues();
            }
        }
    }


}
