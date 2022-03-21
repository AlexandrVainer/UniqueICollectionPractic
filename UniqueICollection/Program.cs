using System;
using System.Collections.Generic;

namespace UniqueICollectionPractic
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueICollection<string> list = new UniqueICollection<string>();
            string? choice = null;
            do
            {
                Out.printMenu();
                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "a":
                        Add(list);
                        break;
                    case "d":
                        Remove(list);
                        break;
                    case "e":
                        Enumerate(list);
                        break;
                    case "b":
                        Contains(list);
                        break;
                    case "c":
                        Clear(list);
                        break;
                }
            } while (choice != "q");

        }

        static void Add(UniqueICollection<string> list)
        {
            Console.WriteLine("Enter text to add :");
            string? str = Console.ReadLine();
            list.Add(str);
        }

        static void Remove(UniqueICollection<string> list)
        {
            Console.WriteLine("Enter text to remove :");
            string? str = Console.ReadLine();
            list.Remove(str);
        }
        static void Enumerate(UniqueICollection<string> list)
        {
            foreach (var item in list)
                Console.WriteLine(item.ToString());
        }
        static void Contains(UniqueICollection<string> list)
        {
            Console.WriteLine("Enter text contans :");
            string? str = Console.ReadLine();
            Console.WriteLine(list.Contains(str));
        }
        static void Clear(UniqueICollection<string> list)
        {
            list.Clear();
        }

    }
}

