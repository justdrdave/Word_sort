using Xunit;

namespace Word_sort
{
    public class longestTest
    {
        [Fact]
        public void findLongest(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("The cow jumped over the moon");
            Assert.Equal("jumped", sorted.Word);
            Assert.Equal(6, sorted.Length);
        }

        [Fact]
        public void emptyString(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("");
            Assert.Equal("", sorted.Word);
            Assert.Equal(0, sorted.Length);
        }

        [Fact]
        public void multipleWordsOfLongestLength(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("The better cow jumped over the moon");
            Assert.Equal("better", sorted.Word);
            Assert.Equal(6, sorted.Length);
        }

        [Fact]
        public void underScoresIncludedInWordLength(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("The cow jumped over the new_moon");
            Assert.Equal("new_moon", sorted.Word);
            Assert.Equal(8, sorted.Length);
        }

        [Fact]
        public void apostrophesIncludedInWordLength(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("The cow didn't jump over the moon");
            Assert.Equal("didn't", sorted.Word);
            Assert.Equal(6, sorted.Length);
        }

        [Fact]
        public void numbersTreatedAsWords(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("1234567 cows jumped over the moon");
            Assert.Equal("1234567", sorted.Word);
            Assert.Equal(7, sorted.Length);
        }

        [Fact]
        public void multipleSpaceBetweenWords(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.longest("The  cow  jumped  over  the  moon");
            Assert.Equal("jumped", sorted.Word);
            Assert.Equal(6, sorted.Length);
        }
    }
}