using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}