using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Algoritms
{
    internal class Tests
    {
        private static int[] _fArr = new int[] { 1, 1, 1, 2, 2, 2, 4, 4 };
        private static int[] _sArr = new int[] { 2, 3, 4, 4, 4 };

        public static void FindMostRepeatedNumber()
        {
            var maxLengh = _fArr.Length + _sArr.Length;
            int countMax = 0;
            int countMaxNum = 0;
            int currCount = 0;
            int number = 0;
            int totalIterations = 0;


            for (int i = 0; i < _fArr.Length; i++)
            {
                currCount = 0;
                number = _fArr[i];


                for (int j = 0; j < _fArr.Length; j++)
                {
                    if (number == _fArr[j])
                        currCount++;
                    totalIterations++;
                }

                for (int j = 0; j < _sArr.Length; j++)
                {
                    if (number == _sArr[j])
                        currCount++;
                    totalIterations++;
                }

                if (countMax < currCount)
                {
                    countMaxNum = number;
                    countMax = currCount;
                    //Console.WriteLine($"число {countMaxNum}  встречается {countMax} раз");
                }
                //totalIterations++;
            }

            for (int i = 0; i < _sArr.Length; i++)
            {
                currCount = 0;
                number = _sArr[i];

                for (int j = 0; j < _fArr.Length; j++)
                {
                    if (number == _fArr[j])
                        currCount++;
                    totalIterations++;
                }

                for (int j = 0; j < _sArr.Length; j++)
                {
                    if (number == _sArr[j])
                        currCount++;
                    totalIterations++;
                }

                if (countMax < currCount)
                {
                    countMaxNum = number;
                    countMax = currCount;
                    // Console.WriteLine($"число {countMaxNum}  встречается {countMax} раз");
                }
                //totalIterations++;
            }

            Console.WriteLine($"число {countMaxNum}  встречается {countMax} раз. Итераций {totalIterations}");


            List<int> all = new List<int>(_sArr.Length + _fArr.Length);
            all.AddRange(_fArr);
            all.AddRange(_sArr);
            all.Sort();
            countMax = 0;
            totalIterations = 0;

            currCount = 0;
            int currnumber;
            currnumber = all[0];
            for (int i = 0; i < all.Count; i++)
            {
                number = all[i];

                if (currnumber == number)
                {
                    currCount++;
                    totalIterations++;
                }
                else
                {
                    currnumber = number;
                    totalIterations++;

                    if (countMax < currCount)
                    {
                        countMaxNum = number;
                        countMax = currCount;
                    }
                    currCount = 1;

                }
                if (i == all.Count - 1 && countMax < currCount)
                {
                    countMaxNum = number;
                    countMax = currCount;
                }
                //totalIterations++;
            }

            Console.WriteLine($"число {countMaxNum}  встречается {countMax} раз. Итераций {totalIterations}");
        }


        public static void FindDiferentParity()
        {
            /*
                Задача: написать функцию для прохождения типового задания с числами в тесте iq — из списка чисел найти то, 
                которое отличается по чётности от остальных, и вернуть его позицию.

                Примеры:
                iqTest("2 4 7 8 10") => 3
                iqTest("1 2 1 1") => 2
            */


            string test_1 = "3 2 4 8 10";
            string test_2 = "1 1 2 1 1";

            Console.WriteLine($"Индекс отличного по чётности числа {FindIndex(test_1.Split(' '))}");
            Console.WriteLine($"Индекс отличного по чётности числа {FindIndex(test_2.Split(' '))}");


            int FindIndex(string[] stAr)
            {
                int currIndex = 0;
                int isParity = 0;
                int isParityFirst = -1;
                int notParity = 0;
                int notParityFirst = -1;

                for (int i = 0; i < stAr.Length; i++)
                {
                    currIndex = i;
                    if (char.IsNumber(stAr[i][0]))
                    {
                        if ((int)stAr[i][0] % 2 == 0)
                        {
                            isParity++;
                            if (isParityFirst == -1)
                                isParityFirst = currIndex + 1;
                        }
                        else
                        {
                            notParity++;
                            if (notParityFirst == -1)
                                notParityFirst = currIndex + 1;
                        }
                    }

                    if(isParity > 0 && notParity > 0)
                    {
                        if (notParity == 1 && isParity > 1) 
                        {
                            if ((int)stAr[i][0] % 2 == 0)
                            {
                                return notParityFirst;
                            }
                                
                            return currIndex + 1;
                        }
                            
                        else if (isParity == 1 && notParity > 1)
                        {
                            if ((int)stAr[i][0] % 2 != 0)
                                return isParityFirst;
                            return currIndex + 1;
                        }
                            
                    }
                 
                }
                return -1;
            }
        }


    }
}
