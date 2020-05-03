using System;

namespace Word_sort
{
    class Program
    {
                static void Main(string[] args)
        {
            Sort sort = new Sort();
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();
            Console.WriteLine("Biggest word is " + sort.longest(sentence).Word + " with length " + sort.longest(sentence).Length);
            Console.WriteLine("Smallest word is " + sort.shortest(sentence).Word + " with length " + sort.shortest(sentence).Length);
        }
    }
}
