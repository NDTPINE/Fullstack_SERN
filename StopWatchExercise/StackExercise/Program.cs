using System;

using System.Collections.Generic;

namespace StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack _stack = new Stack();
            int ini = 0;
            int max = 5;
            for (int i = ini; i <= max; i++)
            {
                _stack.Push(i);
            }
            for (int i = ini; i <= max; i++)
            {
                Console.WriteLine(_stack.Pop());
            }
            Console.ReadLine();
        }
    }
    public class Stack
    {
        private readonly List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException("You can not add null object to the stack");
            }
            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0) 
                throw new InvalidOperationException("There are no elements in stack");
            int v = _list.Count - 1;
            object ToReturn = _list[v];
            _list.RemoveAt(v);
            return ToReturn;
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
