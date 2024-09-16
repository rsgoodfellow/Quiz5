using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz5
{
    internal class Program
    {
        static void stringCount(string input, Dictionary<char, int> charCount)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (charCount.ContainsKey(input[i]))
                {
                    charCount[input[i]]++;
                }

                if (charCount[input[i]] > 1)
                Console.WriteLine((input[i]) " = " + charCount[input[i]]);
            }




        }

        static void Main(string[] args)
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>()
            {
                { 'a', 0 }, { 'b', 0 },{ 'c', 0 },{ 'd', 0 },{ 'e', 0 },{ 'f', 0 },{ 'g', 0 },{ 'h', 0 },{ 'i', 0 },{ 'j', 0 },{ 'k', 0 },{ 'l', 0 },{ 'm', 0 },{ 'n', 0 },{ 'o', 0 },{ 'p', 0 },{ 'q', 0 },{ 'r', 0 },{ 's', 0 },{ 't', 0 },{ 'u', 0 },{ 'v', 0 },{ 'w', 0 },{ 'x', 0 },{ 'y', 0 },{ 'z', 0 }
            };
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            stringCount(input, charCount);

            Console.Read();
        }
    }
}
