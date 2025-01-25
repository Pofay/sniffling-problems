using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace LeetcodePlayground.AlgoMonster.Basics
{
    public class BasicsTest
    {
        [Fact]
        public void NumericArraysHaveDefaultValuesOfZero()
        {
            byte[] bytes = new byte[10];
            Assert.All(bytes, n => Assert.Equal(0, n));

            int[] numbers = new int[10];
            Assert.All(numbers, n => Assert.Equal(0, n));

            long[] longs = new long[10];
            Assert.All(longs, n => Assert.Equal(0, n));

            float[] floats = new float[10];
            Assert.All(floats, n => Assert.Equal(0, n));

            double[] doubles = new double[10];
            Assert.All(doubles, n => Assert.Equal(0, n));

            decimal[] decimals = new decimal[10];
            Assert.All(decimals, n => Assert.Equal(0, n));
        }

        [Fact]
        public void CsharpCharArraysHaveDefaultValuesOfNull()
        {
            char[] chars = new char[10];
            // But this is C# specific, in other languages it might be null
            Assert.All(chars, n => Assert.Equal(0, n));
            // Like this, but both pass in C#
            Assert.All(chars, n => Assert.Equal('\0', n));
        }

        [Fact]
        public void ReferenceTypeArraysHaveDefaultValuesOfNull()
        {
            string[] strings = new string[10];
            Assert.All(strings, n => Assert.Null(n));

            object[] objects = new object[10];
            Assert.All(objects, n => Assert.Null(n));
        }

    }
}