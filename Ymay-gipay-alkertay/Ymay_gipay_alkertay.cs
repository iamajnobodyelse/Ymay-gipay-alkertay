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

            Console.WriteLine("Enter a sentence to translate into Pig Latin.");
            input = (Console.ReadLine()).ToLower();
            Console.WriteLine("In Pig Latin that's:");
            string[] words = input.Split(' ');
            foreach (string output in words)
            {
                if (output.StartsWith("a"))
                {
                    Console.Write(output + "ay ");
                }
                else if (output.StartsWith("e"))
                {
                    Console.Write(output + "ay ");
                }
                else if (output.StartsWith("i"))
                {
                    Console.Write(output + "ay ");
                }
                else if (output.StartsWith("o"))
                {
                    Console.Write(output + "ay ");
                }
                else if (output.StartsWith("u"))
                {
                    Console.Write(output + "ay ");
                }
                else
                {
                    int vowelCheck = output.IndexOfAny("aeiou".ToCharArray());
                    string partOne = output.Substring(vowelCheck);
                    string partTwo = output.Substring(0,vowelCheck);
                    string translated = String.Concat(partOne, partTwo);
                    Console.Write(translated + "ay ");
                   
                }
            }
            Console.ReadKey(true);
        }
    }
}
