using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\@|\#)(?<color>[a-z]{3,})(\@|#)[^A-Za-z0-9]*\/(?<amount>\d+)\/";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);
            Dictionary<string, int> eggs = new Dictionary<string, int>();
            foreach (Match match in matches)
            {
                string currentColorEgg = match.Groups["color"].Value;
                int currentAmount = int.Parse(match.Groups["amount"].Value);
                Console.WriteLine($"You found {currentAmount} {currentColorEgg} eggs!");
            }

        }

    }
}
