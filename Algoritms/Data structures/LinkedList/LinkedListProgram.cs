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
            LinkedListMy<string> names = new LinkedListMy<string>();
            Console.WriteLine(names.IsEmpty);
            names.Add("Bob");
            names.Add("Nik");
            names.Add("Rick");

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine(names.Count);
            names.Remove("Nik");
            Console.WriteLine(names.Count);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
