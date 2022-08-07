using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\${1}|%{1})[A-Z]{1}[a-z]{2,}\1: \[[\d]{1,}]\|\[[\d]{1,}]\|\[[\d]{1,}]\|$";
            int numberofInputs = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberofInputs; i++)
            {
                string message = Console.ReadLine();
                if (Regex.IsMatch(message, pattern))
                {
                    char[] decryptedMessage = message.Where(char.IsNumber).ToArray();
                    char[] decryptedTag = message.Where(char.IsLetter).ToArray();
                    
                    
                    
                    Console.WriteLine($"{decryptedTag}: {decryptedMessage}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}