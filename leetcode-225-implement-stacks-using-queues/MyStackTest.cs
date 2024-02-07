using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Xunit;

namespace LeetcodePlayground.Basics
{
    public class MyStackTest
    {
        [Fact]
        public void StackIsEmptyOnCreation()
        {
            var sut = new MyStack();

            Assert.True(sut.Empty());
        }

        [Fact]
        public void StackShouldNotBeEmptyOnPush()
        {
            var sut = new MyStack();

            sut.Push(2);

            Assert.False(sut.Empty());
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void StackShouldReturnTopMostValue(int value)
        {
            // Given
            var sut = new MyStack();

            // When
            sut.Push(value);
            var actual = sut.Pop();

            // Then
            Assert.Equal(value, actual);
        }

        [Fact]
        public void StackShouldReturnTopMostValueFor3Pushes()
        {
            var sut = new MyStack();

            sut.Push(1);
            sut.Push(2);
            sut.Push(3);
            var actual = sut.Top();

            Assert.Equal(3, actual);
        }

        [Fact]
        public void LeetcodeTest1()
        {
            var sut = new MyStack();

            sut.Push(1);
            sut.Push(2);
            Assert.Equal(2, sut.Top());
            Assert.Equal(2, sut.Pop());
            Assert.False(sut.Empty());
        }
    }
}