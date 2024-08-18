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
                int N = Convert.ToInt32(Console.ReadLine());
                Solution obj = new Solution();
                long res = obj.prime_Sum(N);
                Console.Write(res+"\n");
          }

        }
    }
}

// } Driver Code Ends




//User function Template for C#

class Solution
{
    //Complete this function
	//Function to calculate the sum of prime numbers up to the given number.
    public long prime_Sum(int n)
    {
        long sum =0;
        long count =n;
        bool[] primes = new bool[n+1];
        
        for(int i=2; i<=n; i++){
            primes[i] = true;
        }
        
        for(int j=2; j*j<=n; j++)
        {
            if(primes[j] == true){
                for(int k=j*j; k<=n; k+=j){
                    primes[k] = false;
                }
            }
        }
        
        while(count>0){
            if(primes[count]) sum+=count;
            count--;
        }
        return sum;
    }
}