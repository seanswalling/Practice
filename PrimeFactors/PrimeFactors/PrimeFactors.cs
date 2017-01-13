using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<int> GeneratePrimes(int number)
        {
            var primes = new List<int>();
            for (var candidate = 2;  number > 1; candidate++)
            {
                for(;number % candidate == 0; number /= candidate)
                {
                    primes.Add(candidate);
                }
            }
            return primes;
        }
    }
}
