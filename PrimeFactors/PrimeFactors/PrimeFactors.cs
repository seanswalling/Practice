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
            List<int> Primes = new List<int>();
            if (n > 1)
            {
                Primes.Add(n);
            }
            return Primes;
        }
    }
}
