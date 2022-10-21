using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Algoritms.SEARCH_AND_SORTING_ALGORITHMS.Sort
{
    public class SimpleSorts
    {

        static List<int> Ints = new List<int>();
        static List<int> _col = new List<int>();

        private static List<int> _colSt = new List<int>
        {
            4, 2, 1, 3, 7, 6, 5
        };

        /// <summary>
        /// Сортировка выбором
        /// </summary>
        private static void SortSelection(int[] a)
        {
            int N = a.Length;
            int min = 0, imin = 0, i;
            for (i = 0; i < N - 1; i++)
            {
                //запоминаем предположительно следующие минимальное число
                // и индекс следующего минимального числа
                min = a[i];
                imin = i;
                // в этом цикле ищем минимальный элемент
                for (int j = i + 1; j < N; j++)
                    if (a[j] < min)
                    {
                        min = a[j];
                        imin = j;
                    }
                if (i != imin)
                {
                    // добавление нового элемента в отсортированную часть
                    // Сравниваем и переставляем места  минимального элемента min, с текущим элементом [i] 
                    a[imin] = a[i];
                    a[i] = min;
                }
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        
        public static void SortSelection()
        {
            var col = new List<int>(_colSt);
            SortSelection(col.ToArray());
            
        }

        public static void PrintCol()
        {
            if (_col.Count == 0)
                _col = new List<int>(_colSt);
            _col.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void SortInclusion()
        {
            var col = new List<int>(_colSt);

            int temp;
            int N = col.Count;

            for (int i = 1; i < N; i++)
            {
                temp = col[i];
                int j = i - 1;

                //сравниваем текущее значение temp с предыдущими по индексу j,
                //постепенно убавляя индекс если temp мешьше col[j]
                //тем самым ищем индекс в котором значение col[j] меньше temp
                while (j >= 0 && temp < col[j]) 
                {
                    col[j + 1] = col[j--];
                }
                //устанавлваем текущее значение на свою позицию
                //где текущее значение либо на индексе 0, либо больше предыдущего значения по индексу 
                // temp это col[x], либо  temp(col[x]) это col[0] либо col[x-1] < temp(col[x])
                col[j + 1] = temp;
            }

            col.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }


        public static void SortBuble()
        {
            var col = new List<int>(_colSt);

            for (int i = 0; i < col.Count; i++)
            {
                // каждую итерацию большее число ставиться в конец (col[n])
                for (int j = 0; j < col.Count - i - 1; j++)
                {
                    if (col[j] > col[j + 1]) // если текущее значение больше следующего, происходит замен значений
                    {
                        int temp = col[j];
                        col[j] = col[j + 1]; //меньшее значение смещается ниже по индексу
                        col[j + 1] = temp; // тукущее значение смещается выше по индексу
                    }
                }
            }
            col.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }

    }
}
