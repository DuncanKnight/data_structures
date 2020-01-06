using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquivalentArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int EquivalentArrays(int[] a1, int[] a2)
            {
                if (a1.Length == 0 && a2.Length == 0) return 1;

                bool eq = false;
                int[] arrayMerge = new int[a1.Length + a2.Length];

                Array.Copy(a1, 0, arrayMerge, 0, a1.Length);
                Array.Copy(a2, 0, arrayMerge, a1.Length, a2.Length);

                for (int x = 0; x < arrayMerge.Length; x++)
                {
                    if (IsPresentInArray(a1, arrayMerge[x]) && IsPresentInArray(a2, arrayMerge[x]))
                    {
                        eq = true;
                        continue;
                    }
                    else
                    {
                        eq = false;
                        break;
                    }
                }

                if (eq)
                    return 1;
                else
                    return 0;
            }

            bool IsPresentInArray(int[] arr, int member)
            {
                foreach (int a in arr)
                {
                    if (a == member) return true;
                }

                return false;
            }

            int result = EquivalentArrays(new int[] { 0, 1, 2 }, new int[] { 2, 0, 1 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 0, 1, 2, 1 }, new int[] { 2, 0, 1 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 2, 0, 1 }, new int[] { 0, 1, 2, 1 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 0, 5, 5, 5, 1, 2, 1 }, new int[] { 5, 2, 0, 1 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 5, 2, 0, 1 }, new int[] { 0, 5, 5, 5, 1, 2, 1 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 0, 2, 1, 2 }, new int[] { 3, 1, 2, 0 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 3, 1, 2, 0 }, new int[] { 0, 2, 1, 0 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { 1, 1, 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1, 1, 2 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { }, new int[] { 3, 1, 1, 1, 1, 2 });
            Console.WriteLine(result);

            result = EquivalentArrays(new int[] { }, new int[] { });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
