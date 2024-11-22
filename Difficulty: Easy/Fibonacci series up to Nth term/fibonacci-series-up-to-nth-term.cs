//{ Driver Code Starts
using System;

using System.Collections.Generic;

public class IntArray {
    public static void input(int[] A, int n) {
        string[] stringArray = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++) {
            A[i] = int.Parse(stringArray[i]);
        }
    }

    public static void print(List<int> A) {
        for (int i = 0; i < A.Count; i++) {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }

    public static void print(int[] A) {
        for (int i = 0; i < A.Length; i++) {
            Console.Write(A[i] + " ");
        }
        Console.WriteLine();
    }
}

namespace DriverCode {
class GFG {
    static void Main(string[] args) {
        int testcases;
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) {

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Solution obj = new Solution();
            List<int> res = obj.Series(n);

            IntArray.print(res);

            Console.Write("~" + "\n");
        }
    }
}
}

// } Driver Code Ends



class Solution {
    public List<int> Series(int n) {
      const int MOD = 1000000007;  // Modulo value

        // Create a list to store Fibonacci numbers
        List<int> fib = new List<int>();

        // Handle the case when N is 0, only return the first Fibonacci number (0)
        if (n == 0)
        {
            fib.Add(0);
            return fib;
        }

        // Base cases: Fibonacci of 0 and 1
        fib.Add(0);  // F(0)
        fib.Add(1);  // F(1)

        // Calculate Fibonacci numbers using the recurrence relation
        for (int i = 2; i <= n; i++)
        {
            int nextFib = (fib[i - 1] + fib[i - 2]) % MOD;
            fib.Add(nextFib);
        }

        return fib;
    }
}
