using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        internal static List<int> Generate(int n)
        {
            List<int> primes = new List<int>();
            if (n > 1)
            {
                while (n % 2 == 0)
                {
                    primes.Add(2);
                    n /= 2;
                }
                if (n > 1)
                {
                    primes.Add(n);
                }
            }
            return primes;
        }
    }
}
