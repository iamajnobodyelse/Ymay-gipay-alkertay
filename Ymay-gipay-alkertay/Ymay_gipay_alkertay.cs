using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ymay_gipay_alkertay
{
    class Ymay_gipay_alkertay
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Enter a sentence to translate.");
            input = (Console.ReadLine()).ToLower();
            string[] words = input.Split(' ');
            foreach (string output in words)
            {
                Console.Write(output + " ");
            }
            Console.ReadKey(true);
        }
    }
}
