using System;
using System.Collections.Generic;

namespace P02_BooksWorld
{
    internal class P02_BooksWorld
    {
        static void Main(string[] args)
        {
            var oldGeners = new List<string>(Console.ReadLine().Split(" | "));

            string command = Console.ReadLine();

            while (command != "Stop!")
            {
                string[] tokens = command.Split(" ");
                string action = tokens[0];

                switch (action)
                {
                    case "Join":
                        string genreJoin = tokens[1];

                        if (!oldGeners.Contains(genreJoin))
                        {
                            oldGeners.Add(genreJoin);
                        }
                        break;
                    case "Drop":
                        string genreDrop = tokens[1];

                        if (oldGeners.Contains(genreDrop))
                        {
                            oldGeners.Remove(genreDrop);
                        }
                        break;
                    case "Replace":
                        string oldGenre = tokens[1];
                        string newGenre = tokens[2];

                        if (oldGeners.Contains(oldGenre) && !oldGeners.Contains(newGenre))
                        {
                            int genreIndex = oldGeners.IndexOf(oldGenre);
                            oldGeners.Remove(oldGenre);
                            oldGeners.Insert(genreIndex, newGenre);
                        }
                        break;
                    case "Prefer":
                        int firstIndex = int.Parse(tokens[1]);
                        int secondIndex = int.Parse(tokens[2]);

                        if (firstIndex > 0 && firstIndex < oldGeners.Count && secondIndex > 0 && secondIndex < oldGeners.Count)
                        {
                            string firstGenre = oldGeners[firstIndex];
                            string secondGenre = oldGeners[secondIndex];

                            oldGeners.RemoveAt(firstIndex);
                            oldGeners.Insert(firstIndex, secondGenre);
                            oldGeners.RemoveAt(secondIndex);
                            oldGeners.Insert(secondIndex, firstGenre);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", oldGeners));
        }
    }
}