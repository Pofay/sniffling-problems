using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetcodePlayground.Basics
{
    // Problem statement at https://leetcode.com/problems/implement-queue-using-stacks/

    public class MyQueue
    {
        private Stack<int> stack;

        public MyQueue()
        {
            stack = new();
        }

        public void Push(int x)
        {
            if (Empty())
            {
                stack.Push(x);
                return;
            }

            var intermediate = new Stack<int>();
            var count = stack.Count;

            for (var i = 0; i < count; i++)
            {
                var value = stack.Pop();
                intermediate.Push(value);
            }
            stack.Push(x);
            var intermediateCount = intermediate.Count;
            for (var i = 0; i < intermediateCount; i++)
            {
                var value = intermediate.Pop();
                stack.Push(value);
            }
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public int Peek()
        {
            if (Empty())
            {
                return 0;
            }

            return stack.Peek();
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }
}