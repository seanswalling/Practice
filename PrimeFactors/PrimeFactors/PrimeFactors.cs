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
            int candidate = 2;
            while (n > 1)
            {
                while (n % candidate == 0)
                {
                    primes.Add(candidate);
                    n /= candidate;
                }
                candidate++;
            }
            if (n > 1)
            {
                primes.Add(n);
            }
            return primes;
        }
    }
}
