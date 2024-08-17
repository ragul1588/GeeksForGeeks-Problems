//{ Driver Code Starts
// Initial Template for C#

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
                obj.print_divisors(N);
                Console.WriteLine();
            }

        }
    }
}

// } Driver Code Ends




//User function Template for C#

class Solution
{
    //Complete this function
    //Function to print all the divisors of the given number.
    public void print_divisors(int n)
    {
        List<int> val = new List<int>();
        
       for(int i=1; i*i<=n; i++)
       {
           if(n%i==0){
               val.Add(i);
               if(n/i !=i){
                    val.Add(n/i);
               }
           }
       }
       val.Sort();
       foreach(int r in val)
       {
           Console.Write(r+" ");
       }
    }
}