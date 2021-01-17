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

        // Best Divisor
        // Source: https://www.hackerrank.com/challenges/best-divisor/problem
        static int digitsSum(int n) 
        {
            int sum = 0;
            while(n > 0) 
            {
                sum += n % 10;
                n = n / 10;
            }
            return sum;
        }

        static bool isBetter(int a, int b) 
        {
            int aDigitsSum = digitsSum(a);
            int bDigitsSum = digitsSum(b);
            if ((aDigitsSum > bDigitsSum) || (aDigitsSum == bDigitsSum) && (a < b))
            {
                return true;
            }
            return false;
        }
        
        public static int BestDivisor(int n) 
        {
            int bestDivisor = 1;
            for(int i = 1; i <= n; i++) 
            {
                if(n % i == 0) 
                {
                    if(isBetter(i, bestDivisor)) 
                    {
                        bestDivisor = i;
                    }
                }
            }
            return bestDivisor;
        }

        // Restaurant
        // Source: https://www.hackerrank.com/challenges/restaurant/problem
        public static int restaurant(int l, int b) {
        int k = l*b;
        for(int a = 1; a <= Math.Sqrt(l*b); a++) 
        {
            if( ((l*b) % (a*a) == 0) && ( (l % a == 0) && (b % a == 0) )) 
            {
                k = (l*b) / (a*a);
            }
        }
        return k;
    }

        // Reverse Game
        // Source: https://www.hackerrank.com/challenges/reverse-game/problem
        static int ballInPosition(int n, int index) => index % 2 != 0? index/2 : n-1 - (index)/2;

        public static int ReverseGame(int n, int k) 
        {   
            int index = 0;
            while(ballInPosition(n, index) != k) 
            {
                index++;
            }
            return index;
        }

        // Strange Grid Again
        // Source: https://www.hackerrank.com/challenges/strange-grid/problem
        public static ulong strangeGrid(ulong r, ulong c) => (ulong)(10*((r / 2) + (r % 2) - 1) + 2*(c-1) + ((r+1) % 2));

        // Halloween party
        // Source: https://www.hackerrank.com/challenges/halloween-party/problem
        public static long halloweenParty(int k) => (k/2)*(k/2) + (k % 2 == 1 ? k/2 : 0);

        // Filling Jars
        // Source: https://www.hackerrank.com/challenges/filling-jars/problem
        public static ulong solve(ulong n, ulong[][] operations) 
        {
            ulong mean = 0;
            foreach (var item in operations)
            {
                mean += (item[1]-item[0]+1)*item[2];
            }
            return mean/n;
        }




    }
}
