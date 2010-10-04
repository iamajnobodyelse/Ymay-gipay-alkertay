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
                    int[] array = new int[5];
                    array[0] = output.IndexOf('a');
                    array[1] = output.IndexOf('e');
                    array[2] = output.IndexOf('i');
                    array[3] = output.IndexOf('o');
                    array[4] = output.IndexOf('u');
                    // find the vowel that shows up first
                    int testOne = Array.IndexOf<int>(array, 1);
                    int testTwo = Array.IndexOf<int>(array, 2);
                    int testThree = Array.IndexOf<int>(array, 3);
                    int testFour = Array.IndexOf<int>(array, 4);
                    int testFive = Array.IndexOf<int>(array, 5);

                    Console.Write(testOne);
                    Console.Write(testTwo);
                    Console.Write(testThree);
                    Console.Write(testFour);
                    Console.Write(testFive);
                    Console.WriteLine("");

                    int vowelCheck = output.IndexOfAny("aeiou".ToCharArray()) != -1;
                    string partOne = output.Substring(vowelCheck);
                    string partTwo = output.Substring(0,vowelCheck);
                    string translated = String.Concat(partOne, partTwo);
                    Console.Write(translated + "ay ");

                    /*
                    if ((output.IndexOf('a') = -1) && (output.IndexOf('e') = -1) && (output.IndexOf('i') = -1) && (output.IndexOf('o') = -1) && (output.IndexOf('o') = -1) && (output.IndexOf('u') = -1))
                    {
                        Console.WriteLine("\n\aNext time type real words Dummy!");
                        Console.ReadKey(true);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n\a\a**Argh! You broke me!**\n(That means something went wrong)");
                        Console.ReadKey(true);
                        break;
                    }
                    */
                }
            }
            Console.ReadKey(true);
        }
    }
}
