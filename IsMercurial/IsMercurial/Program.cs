using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsMercurial
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsMercurial(int[] a)
            {
                int isMercurial = 1;
                int firstOne = -1, secondOne = -1, firstThree = -1;

                for (int x = 0; x < a.Length; x++)
                {
                    int current = a[x];

                    if (current == 1 && firstThree == -1)
                    {
                        firstOne = x;
                    }
                    else if (firstThree != -1)
                    {
                        secondOne = x;

                        if (firstThree != -1 && firstOne != -1 && secondOne != -1)
                        {
                            if (firstOne < firstThree && firstThree < secondOne)
                            {
                                isMercurial = 0;
                            }
                        }
                    }
                    else if (current == 3 && firstOne != -1)
                    {
                        firstThree = x;
                    }
                }

                if (firstThree != -1 && firstOne != -1 && secondOne != -1)
                {
                    if (firstOne < firstThree && firstThree < secondOne)
                    {
                        isMercurial = 0;
                    }
                }

                return isMercurial;
            }

            int result = IsMercurial(new int[] { 1, 2, 10, 3, 15, 1, 2, 2 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 5, 2, 10, 3, 15, 1, 2, 2 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 1, 2, 10, 3, 15, 16, 2, 2 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 3, 2, 18, 1, 0, 3, -11, 1, 3 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 2, 3, 1, 1, 18 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 8, 2, 1, 1, 18, 3, 5 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 3, 3, 3, 3, 3, 3 });
            Console.WriteLine(result);

            result = IsMercurial(new int[] { 1 });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
