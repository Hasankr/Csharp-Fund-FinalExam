using System;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = Console.ReadLine();
            while (commands != "Done")
            {
                string[] tokens = commands.Split(" ");
                switch (tokens[0])
                {
                    case "Change":
                        {
                            string ch = tokens[1];
                            string replacement = tokens[2];
                            input = input.Replace(ch, replacement);
                            Console.WriteLine(input);
                            break;
                        }
                    case "Includes":
                        {
                            string substring = tokens[1];
                            if (input.Contains(substring))
                            {
                                Console.WriteLine("True");
                            }
                            else
                            {
                                Console.WriteLine("False");
                               
                            }
                            break;
                        }
                    case "End":
                        {
                            string substring = tokens[1];
                            bool isEnding ;
                            isEnding  = input.EndsWith(substring);
                            if (!isEnding == true)
                            {
                                Console.WriteLine("False");
                            }
                            else
                            {
                                Console.WriteLine("True");
                            }
                            break;
                        }
                    case "Uppercase":
                        {
                            input = input.ToUpper();
                            Console.WriteLine(input);
                        }
                        break;
                    case "FindIndex":
                        {
                            char ch = char.Parse(tokens[1]);
                            for (int i = 0; i < input.Length; i++)
                            {
                                if ( input[i] == ch)
                                {
                                    Console.WriteLine(i);
                                }
                                else
                                {
                                    continue;
                                }
                            }
                     
                            break;
                        }
                    case "Cut":
                        {
                            int startIndex = int.Parse(tokens[1]);
                            int count = int.Parse(tokens[2]);
                            input = input.Remove(startIndex, count);
                            Console.WriteLine(input);
                            break;
                        }

                }
                
                commands = Console.ReadLine();
            }
            

        }
    }
}