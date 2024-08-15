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
                int[] arr = new int[2];
                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);// input for array elements
                int A = arr[0];
                int B = arr[1];
                Solution obj = new Solution();
                int res = obj.addition(A, B);
                Console.Write(res+"\n");
            }

        }
    }
}

// } Driver Code Ends


class Solution
{
    public int addition(int A, int B)
    {
        return A+B;
    }
}