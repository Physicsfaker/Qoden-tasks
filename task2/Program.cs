using System;
using System.Collections.Generic;
using System.Linq;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            var words = text.Split(' ').Where(q => !string.IsNullOrEmpty(q));
            var uniqWrds = words.Select(q => q.Trim()).Distinct();
            var result = new Dictionary<string, int>();

            foreach (var word in uniqWrds)
            {
                result.Add(word, words.Count(q => q.Equals(word)));
            }
        
            result = result.OrderByDescending(q => q.Value).ToList().Take(5).ToDictionary(key => key.Key, value => value.Value);

            var lenghtLongestWord = words.Where(z => z.Length == (words.Max(n => n.Length))).Max().Length;
            var maxWordRepetition = result.Aggregate((l, r) => l.Value > r.Value ? l : r).Value;
            double coefficient = maxWordRepetition / 10.0;

            result = result.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

            foreach (var item in result)
            {
                for (int slash = lenghtLongestWord - item.Key.Length; slash > 0; slash--) Console.Write("_");
                Console.Write(item.Key + " ");
                for (double p = Math.Round(item.Value / coefficient); p > 0; p--) Console.Write(".");
                Console.WriteLine();
            }
        }
    }
}
