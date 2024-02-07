using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;

namespace LeetcodePlayground.Basics
{
    // Problem statement: https://leetcode.com/problems/implement-stack-using-queues/

    public class MyStack
    {
        private Queue<int> queue;

        public MyStack()
        {
            queue = new();
        }

        public void Push(int x)
        {
            if (Empty())
            {
                queue.Enqueue(x);
                return;
            }

            queue.Enqueue(x);
            var temp = new Queue<int>();
            var mainCount = queue.Count - 1;
            for (var i = 0; i < mainCount; i++)
            {
                var value = queue.Dequeue();
                temp.Enqueue(value);
            }
            var tempCount = temp.Count;
            for (var i = 0; i < tempCount; i++)
            {
                var value = temp.Dequeue();
                queue.Enqueue(value);
            }
        }

        public int Pop()
        {
            return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Peek();

        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}