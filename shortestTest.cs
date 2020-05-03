using Xunit;

namespace Word_sort
{
    public class shortestTest
    {
        [Fact]
        public void findshortest(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("A cow jumped over the moon");
            Assert.Equal("A", sorted.Word);
            Assert.Equal(1, sorted.Length);
        }

        [Fact]
        public void emptyString(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("");
            Assert.Equal("", sorted.Word);
            Assert.Equal(0, sorted.Length);
        }

        [Fact]
        public void multipleWordsOfshortestLength(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("The cow jumped over the moon");
            Assert.Equal("The", sorted.Word);
            Assert.Equal(3, sorted.Length);
        }

        [Fact]
        public void underScoresIncludedInWordLength(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("A_ cow jumped over the new_moon");
            Assert.Equal("A_", sorted.Word);
            Assert.Equal(2, sorted.Length);
        }

        [Fact]
        public void apostrophesIncludedInWordLength(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("A' cow didn't jump over the moon");
            Assert.Equal("A'", sorted.Word);
            Assert.Equal(2, sorted.Length);
        }

        [Fact]
        public void numbersTreatedAsWords(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("1 cow jumped over the moon");
            Assert.Equal("1", sorted.Word);
            Assert.Equal(1, sorted.Length);
        }

        [Fact]
        public void multipleSpaceBetweenWords(){
            Sort sort = new Sort();
            Sorted sorted = new Sorted();
            sorted = sort.shortest("The  cow  jumped  over  the  moon");
            Assert.Equal("", sorted.Word);
            Assert.Equal(0, sorted.Length);
        }
    }
}