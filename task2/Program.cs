using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "aa aa bbb bbb bbb bbb bbb c c c c c c c c c ";
            //string text = "aa aa bbb bbb bbb bbb bbb bbb c c c c c c c c c c";
            //string text = "aa aa bbb bbb bbb bbb bbb c c c c c c c c c ";

            var words = text.Split(' ').Where(q => !string.IsNullOrEmpty(q));
            var uniqWrds = words.Select(q => q.Trim()).Distinct();
            var result = new Dictionary<string, int>();

            foreach (var word in uniqWrds)
            {
                result.Add(word, words.Count(q => q.Equals(word)));
            }

            result = result.OrderByDescending(q => q.Value).ToList().Take(5).ToDictionary(key => key.Key, value => value.Value);
            //foreach (var word in result)
            //{
            //    Console.WriteLine($"{word.Key} = {word.Value}");
            //}

            var lenghtLongestWord = words.Where(z => z.Length == (words.Max(n => n.Length))).Max().Length;
            var maxWordRepetition = result.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            double coefficient = maxWordRepetition / 10.0;

            //Console.WriteLine(10 / 10);
            //Console.WriteLine(9 / 2);
            //Console.WriteLine(9 / 3);

            result = result.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var item in result)
            {
                for (int slash = lenghtLongestWord - item.Key.Length; slash > 0; slash--) Console.Write("_");

                Console.Write(item.Key + " ");

                int points = ((double)item.Value) % coefficient >= 5 ? (int)(item.Value / coefficient + 1.0) : (int)(item.Value / coefficient); //??

                for (int p = points; p > 0; p--) Console.Write(".");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
