using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHappy
{
    class Program
    {
        static void Main(string[] args)
        {
            int IsPrimeHappy(int n)
            {
                int isPrimeHappy = 1;
                int count = 0, sum = 0;

                for (int x = 0; x < n; x++)
                {
                    if (IsPrime(x))
                    {
                        count++;
                        sum += n;
                    }
                }

                if (count < 1) isPrimeHappy = 0;
                if (sum % n == 0) isPrimeHappy = 1;

                return 0;
            }

            bool IsPrime(int num)
            {
                if (num <= 1) return false;

                for (int x = 2; x < num / 2; x++)
                {
                    if (num % 2 == 0) return false;
                }
                return true;
            }

            int result = IsPrimeHappy(5);
            Console.WriteLine(result);

            result = IsPrimeHappy(25);
            Console.WriteLine(result);

            result = IsPrimeHappy(32);
            Console.WriteLine(result);

            result = IsPrimeHappy(8);
            Console.WriteLine(result);

            result = IsPrimeHappy(2);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
