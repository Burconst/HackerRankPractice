using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace Algorithm.Warmup
{
    public static class Easy 
    {

        // Simple Array Sum
        // Source: https://www.hackerrank.com/challenges/simple-array-sum/problem
        public static long SimpleArraySum(int[] ar) 
        {
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];            
            }
            return sum;
        }

        // Compare the Triplets
        // Source: https://www.hackerrank.com/challenges/compare-the-triplets/problem
        public static List<int> CompareTriplets(List<int> a, List<int> b) 
        {
            var res = new List<int> { 0, 0 };
            for (int i = 0; i < Math.Min(a.Count, b.Count); i++)
            {
                if(a[i] < b[i]) 
                {
                    res[1]++;
                } 
                else if(a[i] > b[i]) 
                {
                    res[0]++;
                }
            }
            return res;
        }

        // Diagonal Difference
        // Source: https://www.hackerrank.com/challenges/diagonal-difference/problem
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int left = 0;
            int right = 0;
            for(int i = 0; i < arr.Count; i++) 
            {
                left += arr[i][i];
                right += arr[i][arr.Count - 1 - i];
            }
            return Math.Abs(left - right);
        }

        // Plus Minus
        // Source: https://www.hackerrank.com/challenges/plus-minus/problem
        public static void PlusMinus(int[] arr) 
        {
            int pos = 0;
            int zero = 0;
            int neg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0) pos++;
                if(arr[i] == 0) zero++;
                if(arr[i] < 0) neg++;
            }
            Console.WriteLine(((double)pos)/arr.Length);
            Console.WriteLine(((double)neg)/arr.Length);
            Console.WriteLine(((double)zero)/arr.Length);
        }

        // Staircase
        // Source: https://www.hackerrank.com/challenges/staircase/problem
        public static void Staircase(int n) 
        {
            var line = new StringBuilder("");
            for(int i = 1; i < n-1; i++) 
            {
                int k = n - i;
                while(k > 0) 
                {
                    line.Append(" ");
                    k--;
                }
                k = i;
                while(k > 0) 
                {
                    line.Append("#");
                    k--;
                }
                Console.WriteLine(line.ToString());
                line.Clear();
            }
        }


        // Mini-Max Sum
        // Source: https://www.hackerrank.com/challenges/mini-max-sum/problem
        public static void MiniMaxSum(ulong[] arr) 
        {
            var Max = new ulong[] { arr[0], arr[1], arr[2], arr[3] };
            Array.Sort(Max);
            var Min = new ulong[] { Max[0], Max[1], Max[2], Max[3] };
            for (int i = 4; i < arr.Length; i++) 
            {
                if (arr[i] > Max[0]) 
                {
                    Max[0] = arr[i];
                    Array.Sort(Max);
                }
                if (arr[i] < Min[3])
                {
                    Min[3] = arr[i];
                    Array.Sort(Min);
                }
            }

            for (int i = 1; i < 4; i++) 
            {
                Max[0] += Max[i];
                Min[0] += Min[i];
            }
            
            Console.Write(Min[0] + " " + Max[0]);
        }
        

        // Birthday Cake Candles
        // Source: https://www.hackerrank.com/challenges/birthday-cake-candles/problem
        public static int BirthdayCakeCandles(List<int> candles)
        {
            int max = candles.Max();
            return candles.FindAll(x => x == max).Count;
        }


        // Time Conversion
        // Source: https://www.hackerrank.com/challenges/time-conversion/problem
        public static string TimeConversion(string s)
        {
            var res = new StringBuilder();
            bool isNoon = false;
            if (s[0] == '1' && s[1] == '2')
            {
                if (s[8] == 'A')
                {
                    res.Append("00");
                } else 
                {
                    res.Append("12");
                }
                isNoon = true;
            }
            if (!isNoon)
            {
                if (s[8] == 'A')
                {
                    res.Append(s.Substring(0, 2));
                }
                else
                {
                    string hours = s.Substring(0, 2);

                    res.Append((Convert.ToInt16(hours) + 12).ToString());
                }
            }
            res.Append(s.Substring(2, 6));
            return res.ToString();
        }


    }
}