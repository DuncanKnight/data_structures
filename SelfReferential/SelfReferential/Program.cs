using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfReferential
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsSelfReferential(int[] a)
            {
                if (a.Length == 0) return 0;

                for (int x = 0; x < a.Length; x++)
                {
                    int count = 0;
                    
                    foreach (int value in a)
                    {
                        if (value == x)
                            count++;
                    }

                    if (count != a[x]) return 0;
                }

                return 1;
            }

            int result = IsSelfReferential(new int[] { 1, 2, 1, 0 });
            Console.WriteLine(result);

            result = IsSelfReferential(new int[] { 2, 0, 2, 0 });
            Console.WriteLine(result);

            result = IsSelfReferential(new int[] { 2, 1, 2, 0, 0 });
            Console.WriteLine(result);

            result = IsSelfReferential(new int[] { 3, 2, 1, 1, 0, 0, 0 });
            Console.WriteLine(result);

            result = IsSelfReferential(new int[] { 4, 2, 1, 0, 1, 0, 0, 0 });
            Console.WriteLine(result);

            result = IsSelfReferential(new int[] { 5, 2, 1, 0, 0, 1, 0, 0, 0 });
            Console.WriteLine(result);

            result = IsSelfReferential(new int[] { 6, 2, 1, 0, 0, 0, 1, 0, 0, 0 });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
