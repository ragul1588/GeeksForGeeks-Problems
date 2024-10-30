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
                int N = Convert.ToInt32(Console.ReadLine());// Input for size of array
                Solution obj = new Solution();
                int res = obj.isPrime(N);
                Console.Write(res);
                Console.Write("\n");
          
Console.Write("~"+"\n");
}

        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Complete this function
    //Function to check if a number is prime or not.
    public int isPrime(int N)
    {
        if(N<=1) return 0;
        if(N==2) return 1;
        if(N%2==0) return 0;
        
        for(int i=3; i<=Math.Sqrt(N); i+=2){
            if(N%i==0) return 0;
        }
        return 1;
    }
}