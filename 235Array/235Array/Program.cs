using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _235Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is235Array(int[] a)
            {
                if (a.Length == 0 || a == null) return 1;

                int is235Array = 0;

                for (int x = 0; x < a.Length; x++)
                {
                    if ((IsDivisibleBy2(a) + IsDivisibleBy3(a) + IsDivisibleBy5(a) + IsNotDivisibleBy235(a) == a.Length))
                        is235Array = 1;
                    else
                        is235Array = 0;
                }

                return is235Array;
            }

            int IsDivisibleBy2(int[] arr)
            {
                int div2Count = 0;
                foreach (int a in arr)
                {                    
                    if (a % 2 == 0) div2Count++;                    
                }
                return div2Count;
            }

            int IsDivisibleBy3(int[] arr)
            {
                int div3Count = 0;
                foreach (int a in arr)
                {
                    if (a % 3 == 0) div3Count++;                    
                }
                return div3Count;
            }

            int IsDivisibleBy5(int[] arr)
            {
                int div5Count = 0;
                foreach (int a in arr)
                {
                    if (a % 5 == 0) div5Count++;
                }
                return div5Count;
            }

            int IsNotDivisibleBy235(int[] arr)
            {
                int notDiv235Count = 0;
                foreach (int a in arr)
                {
                    if ((a % 5 != 0) && (a % 3 != 0) && (a % 2 != 0)) notDiv235Count++;
                }
                return notDiv235Count;
            }

            int result = Is235Array(new int[] { 2, 3, 5, 7, 11 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 2, 3, 6, 7, 11 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 2, 4, 8, 16, 32 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 3, 9, 27, 7, 1, 1, 1, 1, 1 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 7, 11, 77, 49 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 2 });
            Console.WriteLine(result);

            result = Is235Array(new int[] { });
            Console.WriteLine(result);

            result = Is235Array(new int[] { 7, 2, 7, 2, 7, 2, 7, 2, 3, 7, 7 });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
