using System;

namespace task1
{
    class HashTable
    {
        // N = 1 -> 100
        // x = 0 -> 2^32 -1         =>    size !<100
        //короче у вас кривое тз. если у вас x = [0; 2^32 -1] то в инт это не влезет как указано здесь: public Array<ListNode<int>> values; public void Insert(int newValue); 
        //в uint пожалуйста

        int value;
        ListNode<uint>[] values;    

        public HashTable(int N)
        {
            value = N;
            values = new ListNode<uint>[value];
        }

        public void Insert(uint newValue)//--
        {
            var key = GetHash(newValue);
            if (values[key] == null)
                values[key] = new ListNode<uint>(newValue);
            else values[key].Insert(newValue);
        }

        private int GetHash(uint newValue)
        {
            return (int) newValue % value;
        }

        public void ShowTable()
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write($"{i}: ");
                if(values[i] != null) values[i].ShowValues();
                Console.Write($"\n");
            }
        }
    }
}
