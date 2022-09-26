using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Data_structures.LinkedList
{
    internal class DoublyLinkedList<T> : IEnumerable<T>
    {
        NodeTwo<T> _head = null;
        NodeTwo<T> _tail = null;

        public int Count { get; private set; }

        public void Add(T data)
        {
            NodeTwo<T> newNode = new NodeTwo<T>(data);

            if(_head == null)
                _head = newNode;
            else
            {
                if (_tail == null)
                {
                    _tail = newNode;
                    _head.NextNode = _tail;
                    _tail.PreviousNode = _head;
                }
                else
                {
                    _tail.NextNode = newNode;
                    newNode.PreviousNode = _tail;
                    _tail = newNode;
                }
            }
            Count++;
        }

        public bool Remove(T data)
        {
            NodeTwo<T> current = _head;
            NodeTwo<T> previous = null;
            NodeTwo<T> next = null;

            while(current != null)
            {
                if (current.Data.Equals(data))
                    break;
                current = current.NextNode;
            }
            if (current != null)
            {
                if (current.NextNode != null)
                {
                    current.NextNode.PreviousNode = current.PreviousNode;
                }
                else
                {
                    _tail = current.PreviousNode;
                }

                if (current.PreviousNode != null)
                {
                    current.PreviousNode.NextNode = current.NextNode;
                }
                else
                {
                    _head = current.NextNode;
                }
                Count--;
                return true;
            }
            return false;
        }

        public void Clear()
        {
            Count = 0;
            _head = null;
            _tail = null;
        }

        public void AddFirst(T data)
        {
            NodeTwo<T> newNode = new NodeTwo<T>(data);
            NodeTwo<T> temp = _head;
            newNode.NextNode = _head;
            
            if (Count == 0)
            {
                _tail = newNode;
            }
            else
            {
                _head.PreviousNode = newNode;
            }
            _head = newNode;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            NodeTwo<T> current = _head;
            while(current != null)
            {
                yield return current.Data;
                current = current.NextNode;
            } 
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
