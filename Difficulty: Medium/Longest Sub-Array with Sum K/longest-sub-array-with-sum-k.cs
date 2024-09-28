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

                var ip = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(ip[0]);
                int k = int.Parse(ip[1]);
                int[] arr = new int[n];
                ip = Console.ReadLine().Trim().Split(' ');
                for (int i = 0; i < n; i++)
                {
                    arr[i] = int.Parse(ip[i]);
                }
                Solution obj = new Solution();
                var res = obj.lenOfLongSubarr(arr, n, k);
                Console.WriteLine(res);
            }

        }
    }
}

// } Driver Code Ends




class Solution
{
    public int lenOfLongSubarr(int[] A, int N, int K)
    {
         int maxVal=0, sum =0;
         
         Dictionary<int,int> Dict = new Dictionary<int,int>();
         
         for(int i=0; i<A.Length; i++){
            
            sum = sum + A[i];
            
            if(sum==K) maxVal = Math.Max(maxVal, i+1);
            
            int val = sum - K; 
            if(Dict.ContainsKey(val)){
                maxVal = Math.Max(i-Dict[val], maxVal);
            }
            if(!Dict.ContainsKey(sum)){
                Dict[sum] = i;
            }
            
         }
         
      return maxVal;
    }
}