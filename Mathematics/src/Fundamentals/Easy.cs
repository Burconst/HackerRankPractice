using System;

namespace Mathematics.Fundamentals
{
    public static class Easy
    {
        // Maximum Draws
        // Source: https://www.hackerrank.com/challenges/maximum-draws/problem
        public static int MaximumDraws(int n)  => n+1;

        // Handshake
        // Source: https://www.hackerrank.com/challenges/handshake/problem
        public static int Handshake(int n) => n*(n-1)/2;

        // Minimum Height Triangle
        // Source: https://www.hackerrank.com/challenges/lowest-triangle/problem
        public static int LowestTriangle(int bas, int area) => (area%bas) == 0 ? 2*(area/bas) : (2*(area/bas) + (area%bas > bas/2 ? 2 : 1));
    
        // Army Game
        // Source: https://www.hackerrank.com/challenges/game-with-cells/problem
        public static int GameWithCells(int n, int m) => (n % 2 == 0 ? n/2 : (n+1)/2)*(m % 2 == 0 ? m/2 : (m+1)/2);

        // Leonardo's Prime Factors
        // Source: https://www.hackerrank.com/challenges/leonardo-and-prime/problem
        public static int PrimeCount(long n) 
        {
            long primeProduct = 1;
            int count = 0;

            long _nextPrime = 1;
            while(primeProduct < n)
            {
                long previous = _nextPrime;
                _nextPrime = nextPrime(previous, n);
                try 
                {
                    primeProduct = checked(primeProduct*_nextPrime);
                }
                catch 
                {
                    return count;
                }   
                if (primeProduct > n) break;
                count ++;
            }
            return count;
        }   
 
        static long nextPrime(long previous, long max) 
        {
            long next = previous;
            while(next < max)
            {
                next++;
                if(isPrime(next))
                {
                    return next;
                }
            }
            return previous;
        }

        static bool isPrime(long number) 
        {
            if (number <= 1) return false;
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if(number % i == 0) return false;
            }
            return true;
        }

        // Connecting Towns
        // Source: https://www.hackerrank.com/challenges/connecting-towns/problem
        public static int ConnectingTowns(int n, int[] routes) 
        {
            int result = 1;
            ulong tmp = 1;
            for(int i = 0; i < n-1; i++) 
            {
                tmp = (ulong)result * (ulong)routes[i];
                if(tmp >=  1234567) 
                {
                    result = (int) (tmp % ((ulong)1234567));
                }
                else 
                {
                    result = (int) tmp;
                }
            }
            return result;
        }

        // Cutting Paper Squares
        // Source: https://www.hackerrank.com/challenges/p1-paper-cutting/problem
        static System.Numerics.BigInteger solve(int n, int m) 
        {
            System.Numerics.BigInteger res = n;
            return  res*m - 1;
        }

    }
}
