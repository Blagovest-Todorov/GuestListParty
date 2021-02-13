using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbCommands = int.Parse(Console.ReadLine());
            List<string> people = new List<string>(numbCommands);

            for (int i = 0; i < numbCommands; i++)
            {
                string[] message = Console.ReadLine().Split(' ');
                string namePerson = message[0]; //on the first place always is the Name

                if (message.Length == 3)
                {
                    if (!(people.Contains(namePerson)))
                    {
                        people.Add(namePerson);
                    }
                    else
                    {
                        Console.WriteLine($"{namePerson} is already in the list!");
                    }

                }
                else // if the message != 3 -> all the rest cases;
                {
                    if (people.Contains(namePerson))
                    {
                        people.Remove(namePerson);
                    }
                    else // if (!people.Contains(namePerson))
                    {
                        Console.WriteLine($"{namePerson} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join('\n', people));
        }
    }
}
