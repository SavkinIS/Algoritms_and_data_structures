using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Data_structures.LinkedList
{
    internal class LinkedListProgram
    {
        public static void Program()
        {
            #region LinkedList
            //LinkedListMy<string> names = new LinkedListMy<string>();
            //Console.WriteLine(names.IsEmpty);
            //names.Add("Bob");
            //names.Add("Nik");
            //names.Add("Rick");

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //Console.WriteLine(names.Count);
            //names.Revert();
            //Console.WriteLine(names.Count);
            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            #endregion

            #region DoublyLinkedList
            DoublyLinkedList<string> names2 = new DoublyLinkedList<string>();
            names2.AddFirst("Bob");
            names2.Add("Nik");
            names2.Add("Rick");
            Console.WriteLine(names2.Count);

            foreach (var item in names2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            names2.AddFirst("Kate");

            foreach (var item in names2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            names2.Reverse();
            foreach (var item in names2)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
