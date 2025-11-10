using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks.Dataflow;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;

namespace LINQFluent
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] book = File.ReadAllLines("test.txt");

            int linesMoreThan30 = book.Count(s => s.Length > 30);

            Console.WriteLine($"Number of lines with more than 30 characters: {linesMoreThan30}");

            double avgLineRead = book
                .Select(s => s.Length)
                .Average();

            Console.WriteLine($"Average line length: {avgLineRead}");

            bool anyLargerThan120 = book
                .Any(s => s.Length > 120);

            Console.WriteLine($"Any line larger than 120 characters? {anyLargerThan120}");

            IEnumerable<string> wordY = book
                .Where(s => s.Contains('Y'))
                .Select(s => s.Trim().Split()[0].ToUpper());

            foreach (string word in wordY)
            {
                Console.WriteLine(word);
            }
        }
    }
}
