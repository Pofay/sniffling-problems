using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetcodePlayground.Basics
{
    public class MyQueueTest
    {
        [Fact]
        public void QueueIsEmptyOnCreation()
        {
            var sut = new MyQueue();

            Assert.True(sut.Empty());
        }

        [Fact]
        public void QueueIsNotEmptyOnceElementIsPushed()
        {
            var sut = new MyQueue();

            sut.Push(1);

            Assert.False(sut.Empty());
        }

        [Fact]
        public void QueueShouldReturn0WhenPeekingOnCreation()
        {
            var sut = new MyQueue();
            var expected = 0;

            var actual = sut.Peek();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void QueueIsEmptyAfterPushAndPop()
        {
            var sut = new MyQueue();

            sut.Push(1);
            sut.Pop();

            Assert.True(sut.Empty());
        }

        [Fact]
        public void QueueShouldReturnFirstElementAfterPushAndPeek()
        {
            var sut = new MyQueue();
            var expected = 1;

            sut.Push(1);
            var actual = sut.Peek();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void QueueShouldReturnFirstElementAfter2PushesAndPeek()
        {
            var sut = new MyQueue();
            var expected = 1;

            sut.Push(1);
            sut.Push(2);
            var actual = sut.Peek();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void LeetcodeValues()
        {
            var sut = new MyQueue();

            sut.Push(1);
            sut.Push(2);
            Assert.Equal(1, sut.Peek());
            sut.Pop();
            Assert.Equal(2, sut.Peek());
            Assert.False(sut.Empty());
        }

        [Fact]
        public void LeetCodeValues2()
        {
            // ["MyQueue","push","push","push","push","pop","push","pop","pop","pop","pop"]
            // [[],[1],[2],[3],[4],[],[5],[],[],[],[]]

            var sut = new MyQueue();

            sut.Push(1);
            sut.Push(2);
            sut.Push(3);
            sut.Push(4);
            Assert.Equal(1, sut.Pop());
            sut.Push(5);
            Assert.Equal(2, sut.Pop());
            Assert.Equal(3, sut.Pop());
            Assert.Equal(4, sut.Pop());
            Assert.Equal(5, sut.Pop());
        }
    }
}