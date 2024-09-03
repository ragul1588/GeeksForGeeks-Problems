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

                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                int[] arr1 = Array.ConvertAll(elements.Split(), int.Parse);
                for (int i = 0; i < n; i++)
                {
                    arr[i] = arr1[i];
                }
                Solution obj = new Solution();
                obj.mergeSort(arr, 0, n - 1);
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
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
    public void merge(int[] arr, int low, int mid, int high)
    {
       int left = low, right = mid+1;
       List<int> temp = new List<int>();
       
       while(left<=mid && right<=high){
         if(arr[left]<=arr[right])
         {
           temp.Add(arr[left]);
           left++;
         }
         else{
           temp.Add(arr[right]);
           right++;
         }
       }
        while(left<=mid){
          temp.Add(arr[left]);
          left++;
        }
        
        while(right<=high){
         temp.Add(arr[right]);
         right++;
        }
        
        for(int i= low; i<=high; i++){
         arr[i] = temp[i-low];
        }
    }

    //Complete this function
    public void mergeSort(int[] arr, int low, int high)
    {
        if(low>=high){
         return;
        }
        
        int mid = (low+high)/2;
        mergeSort(arr, low, mid);
        mergeSort(arr, mid+1, high);
        merge(arr, low, mid, high);
    }
}