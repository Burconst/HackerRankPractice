using System;
using System.Collections.Generic;

namespace DataStructures.Arrays
{
    public static class Easy
    {

        // Arrays - DS
        // Source: https://www.hackerrank.com/challenges/arrays-ds/problem
        public static int[] ReverseArray(int[] a) {
            for(int i = 0; i < a.Length/2; i++) 
            {
                int tmp = a[i];
                a[i] = a[a.Length-1 - i];
                a[a.Length-1 - i] = tmp;
            }
            return a;
        }


        // 2D Array - DS
        // Source: https://www.hackerrank.com/challenges/2d-array/problem
        public static int HourglassSum(int[][] arr)
        {
            int maxSum = -64;
            for (int i = 1; i < 5; i++) 
            {
                for (int j = 1; j < 5; j++)  
                {
                    int sum = arr[i][j] + arr[i+1][j-1] + arr[i+1][j] + arr[i+1][j+1]+arr[i-1][j-1] + arr[i-1][j] + arr[i-1][j+1];
                    
                    if(sum > maxSum) 
                    {
                        maxSum = sum;
                    }
                }
            }
            return maxSum;
        }

        // Dynamic Array
        // Source: https://www.hackerrank.com/challenges/dynamic-array/problem
        public static List<int> DynamicArray(int n, List<List<int>> queries)
        {
            var asnv = new List<int>();
            int lastAnswer = 0;
            var arr = new List<int>[n];
            foreach (var query in queries)
            {
                if(query[0] == 1) 
                {
                    int idx = (query[1] ^ lastAnswer) % n;
                    if(arr[idx] == null) arr[idx] = new List<int>();
                    arr[idx].Add(query[2]);

                }
                if(query[0] == 2) 
                {
                    int idx = (query[1] ^ lastAnswer) % n;
                    if(arr[idx] == null) arr[idx] = new List<int>();
                    lastAnswer = (arr[idx])[query[2] % arr[idx].Count];
                    asnv.Add(lastAnswer);
                }
            }
            return asnv;
        }

        // Left Rotation
        // Source: https://www.hackerrank.com/challenges/array-left-rotation/problem
        public static List<int> RotateLeft(int d, List<int> arr)
        {
            if(arr.Count == 0 || d % arr.Count == 0) return arr; 
            d = d % arr.Count;
            var initialElems = new int[d];
            for(int i = 0; i < d; i++) 
            {
                initialElems[i] = arr[i];
            }
            for(int i = 0; i < arr.Count; i++) 
            {
                int nextIndex = (d + i) % arr.Count;
                arr[i] = arr[nextIndex];

            }
            for(int i = arr.Count-d; i < arr.Count; i++) 
            {
                arr[i] = initialElems[i - (arr.Count-d)];
            }  
            return arr;
        }

    }
}
