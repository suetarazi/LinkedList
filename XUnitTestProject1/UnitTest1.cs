using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void NodeClassHasValueProperty()
        {
            Node node = new Node();

            Assert.IsType<int>(node.Value);

        }

        [Fact]
        public void CanGetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;

            Assert.Equal(10, node.Value);

        }

        [Fact]
        public void CanChangeAndSetValueOfValuePropertyInNode()
        {
            Node node = new Node();
            node.Value = 10;
            node.Value = 15;

            Assert.Equal(15, node.Value);

        }

        [Fact]
        public void NodeClassHasNextProperty()
        {
            Node node = new Node();
            Assert.Null(node.Next);
        }

        [Fact]
        public void NextPropertyOnNodeCanBeSet()
        {
            Node node = new Node();
            node.Value = 18;

            Node node2 = new Node();
            node.Next = node2;

            Assert.Equal(node.Next, node2);
        }

        [Fact]
        public void LinkedListClassHasHeadProperty()
        {
            Linklist linklist = new Linklist();
            Assert.Null(linkList.Head);
        }

        [Fact]
        public void CanInsertNewNodeToLinkedListAsHead()
        {
            Linklist 11 = new Linklist();
            11.Insert(10);
            Assert.Equal(10, 11.Head.Value);

        }

        [Fact]
        public void CanInsertNewNodeAsHeadInLLThatAlreadyHasNodes()
        {
            Linklist 11 = new Linklist();
            11.Insert(10);
            11.Insert(20);

            Assert.Equal(20, 11.HeadValue);

        }


        [Fact]
        public void CanFindNodeWithValueInLL()
        {

            Linklist 11 = new Linklist();
            11.Insert(10);
            11.Insert(20);
            11.Insert(30);
            11.Insert(42);

            bool exists = 11.Includes(30);

            Assert.True(exists);

        }

        [Fact]
        public void CannotFindNodewithValueinLL()
        {
            Linklist 11 = new Linklist();
            11.Insert(10);
            11.Insert(20);
            11.Insert(30);
            11.Insert(42);

            bool exists = 11.Includes(32);

            Assert.False(exists);


        }

        [Fact]
        public void CanFindHeadValueSucessfullyinLL()
        { 
            Linklist 11 = new Linklist();
            11.Insert(10);
            11.Insert(20);
            11.Insert(30);
            11.Insert(42);

            bool exists = 11.Includes(42);
            Assert.True(exists);

        }

        [Fact]
        public void CanFindLastNodeValueInLL()
        { 
            Linklist 11 = new Linklist();
            11.Insert(10);
            11.Insert(20);
            11.Insert(30);
            11.Insert(42);

            bool exists = 11.Includes(10);
            Assert.True(exists);
        }

        [Fact]
        public void CanConvertLinkListToString()
        {
            Linklist 11 = new Linklist();
            11.Insert(10);
            11.Insert(20);
            11.Insert(30);
            11.Insert(42);

            string testString = 11.ToString();

            string expected = $"42 -> 30 -> 20 -> 10 -> NULL";

            Assert.Equal(expected, testString);


        }

    }
}
