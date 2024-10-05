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

                var ip = Console.ReadLine().Trim().Split(' ');
                int n = int.Parse(ip[0]);
                long k = long.Parse(ip[1]);
                List<int> arr = new List<int>();
                arr = Console.ReadLine().Trim().Split(' ').ToList().Select(x => int.Parse(x)).ToList();
                Solution obj = new Solution();
                var res = obj.countSubArrayProductLessThanK(arr, n, k);
                Console.WriteLine(res);
            }

        }
    }
}

// } Driver Code Ends


//User function Template for C#

class Solution
{
    //Complete this function
    public long countSubArrayProductLessThanK(List<int> a, int n, long k)
    {
        int left =0, right =0;
        long sum  = 1;
        long count =0;
        
        for(right=0; right<a.Count; right++){
            sum *=a[right];
            
            while(sum>=k && left<=right){
                sum /=a[left];
                left++;
            }
            
            count = count+ right -left +1;
            
        }
        return count;
    }
}