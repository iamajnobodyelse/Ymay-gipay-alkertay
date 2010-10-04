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
                    int letterA = output.IndexOf('a');
                    int letterE = output.IndexOf('e');
                    int letterI = output.IndexOf('i');
                    int letterO = output.IndexOf('o');
                    int letterU = output.IndexOf('u');
                    if ((letterA != 0) && (letterA < letterE) && (letterA < letterI) && (letterA < letterO) && (letterA < letterU))
                    {
                        Console.Write(output + "1 ");
                    }
                    else if ((letterE != 0) && (letterE < letterA) && (letterE < letterI) && (letterE < letterO) && (letterE < letterU))
                    {
                        Console.Write(output + "2 ");
                    }
                    else if ((letterI != 0) && (letterI < letterA) && (letterI < letterE) && (letterI < letterO) && (letterI < letterU))
                    {
                        Console.Write(output + "3 ");
                    }
                    else if ((letterO != 0) && (letterO < letterA) && (letterO < letterE) && (letterO < letterI) && (letterO < letterU))
                    {
                        Console.Write(output + "4 ");
                    }
                    else if ((letterU != 0) && (letterU < letterA) && (letterU < letterE) && (letterU < letterI) && (letterU < letterO))
                    {
                        Console.Write(output + "5 ");
                    }
                    else
                    {
                        Console.WriteLine("\n\a**Argh! You broke me!**\n(That means something went wrong)");
                        Console.ReadKey(true);
                        break;
                    }

                }
            }
            Console.ReadKey(true);
        }
    }
}
