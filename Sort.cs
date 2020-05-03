using System.Linq;

namespace Word_sort
{
    public class Sort
    {
        
        public Sorted longest(string sentence){
            string[] wordList = splitter(sentence);
            var biggest = wordList.OrderByDescending(n => n.Length).First();
            Sorted sorted = new Sorted();
            sorted.Word = biggest;
            sorted.Length = biggest.Length;
            return sorted;
        }

        public Sorted shortest(string sentence){
             string[] wordList = splitter(sentence);
            var smallest = wordList.OrderBy(n => n.Length).First();
            Sorted sorted = new Sorted();
            sorted.Word = smallest;
            sorted.Length = smallest.Length;
            return sorted;
        }

        private string[] splitter (string sentence){
            return sentence.Split(' ');

        }
    }

    public class Sorted
    {
        public string Word { get; set; }
        public int Length { get; set; }
        public Sorted(string word, int length)
        {
            Word = word;
            Length = Length;
        }

        public Sorted()
        {
        }
    }
}