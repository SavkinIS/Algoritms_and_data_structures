using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Data_structures.LinkedList
{
    public class LinkedListMy<T> : IEnumerable<T>
    {
        private NodeOne<T> _head { get; set; }
        private NodeOne<T> _tail { get; set; }
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public void Add(T data)
        {
            NodeOne<T> node = new NodeOne<T>(data);

            //если список пуст, то начальный элемент списка становиться
            //добавленный элемент с сылкой на следующий как null
            // node.Data == data --> true
            // node.NextNode == null --> true
            // если в списке содержется еще елементы то
            // последнему элементу в Свойство записиывется новый экзепляр,
            // после уже сам последний елемент ссылается на новый экзепляр
            // это почти как очередь, на лестнице
            //  ___ head(element0)
            //     |___ element1
            //         |___ element2
            //             |___ element3
            //                 |___ tail(element4)
            //

            if (_head == null)
                _head = node;
            else
                _tail.NextNode = node;

            _tail = node;
            Count++;
        }

        public bool Remove(T data)
        {
            NodeOne<T> current = _head;
            NodeOne<T> previous = null;

            /*
             *  Начинается перебор списка 
             *  если елемент совпадает с искомым то
             *      ЕСЛИ искомый елемент в начале, то элемент на который ссылается головной елемент становитс головной
             *          и если головной элемент становиться null (так как изначально головной елемент не ссылался на ни на него),
             *          то и конечный елемент становится null             *  
             *      ИНАЧЕ 
             *          предыдущиму елементу ссылка на следующий элемент устанавливается из проверяемого элемента
             *          если ссылка у проверяемого элемента на следующий элемент равна null,
             *          то последним элементом становится предыдущий елемент
             *          
             *          previous --> current --> Next
             *              |----------->>>>-----|
             *              
             *  если за итерацию не найден искомый элемент,
             *  то передыдущий элемент становится проверяемый элемент, а проверяемый элемент следующим элементом
             *  previous = current и current = current.NextNode
             */

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.NextNode = current.NextNode;
                        if (previous.NextNode == null)
                            _tail = previous;
                    }
                    else
                    {
                        _head = _head.NextNode;

                        if (_head == null)
                            _tail = null;
                    }
                    Count--;
                    return true;                   
                }
                previous = current;
                current = current.NextNode;
            }
            return false;
        }

        public void Revert()
        {
            NodeOne<T> current = _head;
            NodeOne<T> next = null;
            NodeOne<T> previos = null;

            while(current != null)
            {
                next = current.NextNode;
                current.NextNode = previos;
                previos = current;
                current = next;
            }
            previos = _tail;
            _tail = _head;
            _head = previos;
        }

        public bool Contains(T data)
        {
            NodeOne<T> current = _head;
            NodeOne<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                previous = current;
            }
            return false;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            NodeOne<T> current = _head;
            while (current != null)
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
