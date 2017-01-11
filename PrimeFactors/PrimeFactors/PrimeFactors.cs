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
            
            for (int candidate = 2; n > 1; candidate++)
            {
                for ( ; n % candidate == 0; n/=candidate)
                {
                    primes.Add(candidate);
                }
            }
            return primes;
        }
    }
}
