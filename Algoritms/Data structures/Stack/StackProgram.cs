using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Data_structures.Stack
{
    public class StackProgram
    {
       static FixedStack<string> _stack = new FixedStack<string>(2);
        
        public static void Program()
        {
            _stack.Push("A");
            Console.WriteLine(_stack.Count.ToString());
            Console.WriteLine();

            _stack.Push("B");
            _stack.Push("C");
            _stack.Push("D");
            Console.WriteLine(_stack.Count.ToString());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine(_stack.Peek());
            Console.WriteLine(_stack.Count.ToString());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Count.ToString());
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine(_stack.Pop());
            Console.WriteLine(_stack.Count.ToString());
            Console.WriteLine();
            Console.ReadLine();
            try
            {
                Console.WriteLine(_stack.Pop());
                Console.WriteLine(_stack.Count.ToString());
                Console.WriteLine();
                Console.ReadLine();

                Console.WriteLine(_stack.Pop());
                Console.WriteLine(_stack.Count.ToString());
                Console.WriteLine();
                Console.ReadLine();

                Console.WriteLine(_stack.Pop());
                Console.WriteLine(_stack.Count.ToString());
                Console.WriteLine();
                Console.ReadLine();

                Console.WriteLine(_stack.Pop());
                Console.WriteLine(_stack.Count.ToString());
                Console.WriteLine();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
