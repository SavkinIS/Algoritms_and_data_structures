using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Data_structures.LinkedList
{
    public abstract class Node<T> 
    {
        protected Node(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
    }

    public class NodeOne<T> : Node<T>
    {
        public NodeOne(T data) : base(data)
        {
        }

        public NodeOne<T> NextNode { get; set; }
    }

    public class NodeTwo<T> : Node<T>
    {
        public NodeTwo(T data) : base(data)
        {
        }

        public NodeTwo<T> NextNode { get; set; }
        public NodeTwo<T> PreviousNode { get; set; }
    }
}
