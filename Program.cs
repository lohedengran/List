using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Adam", "Eva" };
            PrintList(names);

            AddName(names);

            RemoveName(names);

            SortNames(names);

        }


        private static void PrintList(List<string> names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void AddName(List<string> names)
        {
            bool addMoreNames = true;
            do
            {
            Console.WriteLine("Would you like to add a name to the list? Press Y.");
            string answer = Console.ReadLine();
            answer = answer.ToLower();
                if (answer == "y")
                {
                    Console.WriteLine("Add a name to list: ");
                    names.Add(Console.ReadLine());
                }
                else
                    addMoreNames = false;

            } while (addMoreNames);   
            
        }
        private static void RemoveName(List<string> names)
        {
            Console.Clear();
            PrintList(names);
            Console.WriteLine("What name would you like to remove?");
            string input = Console.ReadLine();
            if (names.Contains(input))
                names.Remove(input);
            else
                Console.WriteLine("Name not found");
            PrintList(names);
        }
        private static void SortNames(List<string> names)
        {
            Console.Clear();
            names.Sort();
            Console.WriteLine("The names in alphabetical order:");
            PrintList(names);
        }

    }
}
