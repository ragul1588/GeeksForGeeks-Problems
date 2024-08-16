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
                int N = Convert.ToInt32(Console.ReadLine());// Input for size of array

                Solution obj = new Solution();
                List<int> res = obj.getTable(N);
                for(int i = 0;i<res.Count;i++){
                    Console.Write(res[i]+" ");
                }
                Console.Write("\n");
          }

        }
    }
}

// } Driver Code Ends




//User function Template for C#

class Solution
{
    //Complete this function
    public List<int> getTable(int N)
    {
        List<int> dt = new List<int>();
        for(int i=1; i<=10; i++)
        {
            dt.Add(i*N);
        }
        return dt;
    }
}