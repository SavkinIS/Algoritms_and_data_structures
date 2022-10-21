using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.BASIC_CONCEPTS
{
    internal class BasicConcepts
    {

        public static void FindsMaxInArray()
        {
            int[] a = new int[]
            {
                1, 3, 4, 4 ,7 , 8 , 9, 5
            };

            int max = a[0];

            for (int i = 0; i < a.Length; i++)  // N
            {
                if (a[i] > max) // N
                {
                    max = a[i]; // m
                }
            }

            Console.WriteLine(max);

            /*
             * 
             * 
             
             T(N) = (2N + m) * t
             
             */
        }
    }
}
