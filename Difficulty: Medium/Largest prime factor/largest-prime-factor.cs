//{ Driver Code Starts
//Initial Template for C#


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            int testcases;// Taking testcase as input
            testcases = Convert.ToInt32(Console.ReadLine());
            while (testcases-- > 0)// Looping through all testcases
            {
                long N = Convert.ToInt64(Console.ReadLine());// Input for size of array
                Solution obj = new Solution();
                long res = obj.largestPrimeFactor(N);
                Console.Write(res);
                Console.Write("\n");
          }

        }
    }
}
// } Driver Code Ends






//User function Template for C#
public class Solution
{
    //Complete this function
    //Function to find the largest prime factor of a given number N.
    public long largestPrimeFactor(long N)
    {
        long largestPrimeFactor =0;
        for(int i=2; i*i<=N; i++)
        {
            if(N%i==0)
            {
               while(N%i==0)
               {
                 largestPrimeFactor = i;
                 N=N/i;
               }
            }
        }
        if(N>1) return N;
        else return largestPrimeFactor;
    }
}