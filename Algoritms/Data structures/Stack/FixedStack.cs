using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Data_structures.Stack
{
    public class FixedStack<T>
    {
        private T[] _stack;
        private const int n = 10;
        public int Count { get; private set; }

        public FixedStack()
        {
            _stack = new T[n];
        }

        public FixedStack(int length)
        {
            _stack = new T[length];
        }

        public bool IsEmpty => Count == 0;

        public void Push(T item)
        {
            if (Count == _stack.Length)
                Resize(_stack.Length * 2);
            _stack[Count] = item;
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            Count--;
            T item = _stack[Count];
            _stack[Count] = default(T);

            if (Count < _stack.Length / 2  + 1)
                Resize(_stack.Length / 2 + 1);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст");

            return _stack[Count - 1];
        }


        public void Resize(int length)
        {
            T[] newItems = new T[length];
            for (int i = 0; i < _stack.Length; i++)
            {
                if (_stack[i] == null)
                    continue;
                newItems[i] = _stack[i];
            }
            _stack = newItems;
        }
    }

}
