﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is123Array(int[] a)
            {
                if (a.Length == 0 || a.Length < 3 || a.Length % 3 != 0) return 0;

                bool order = false;
                int[] sequence = new int[] { 1, 2, 3 };

                for (int x = 0; x < sequence.Length; x++)
                {
                    if (IsPresentInArray(a, sequence[x]) && a.Length > sequence.Length)
                    {
                        if (a[3] != sequence[0])
                        {
                            order = false;
                            break;
                        }
                        else
                        {
                            order = true;
                            continue;
                        }
                    }

                    if (IsPresentInArray(a, sequence[x]) && a.Length == sequence.Length)
                    {
                        order = true;
                        continue;
                    }
                    else
                    {
                        order = false;
                        break;
                    }
                }

                if (order) return 1;                
                else return 0;
            }

            bool IsPresentInArray(int[] arr, int member)
            {
                foreach (int a in arr)
                {
                    if (a == member) return true;
                }

                return false;
            }

            int result = Is123Array(new int[] { 1, 2, 3, 3, 2, 1 });
            Console.WriteLine(result);

            result = Is123Array(new int[] { 0, 1, 2, 3, 1, 2, 3 });
            Console.WriteLine(result);

            result = Is123Array(new int[] { 1, 2, 3, 3, 2, 1, 1, 2, 3 });
            Console.WriteLine(result);

            result = Is123Array(new int[] { 1, 2, 3 });
            Console.WriteLine(result);

            result = Is123Array(new int[] { });
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
