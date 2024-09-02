//{ Driver Code Starts
// Initial Template for C#

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode {

class GFG {
    static void Main(string[] args) {
        int testcases; // Taking testcase as input
        testcases = Convert.ToInt32(Console.ReadLine());
        while (testcases-- > 0) // Looping through all testcases
        {

            // var ob = new Solution();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(), int.Parse);
            Solution obj = new Solution();
            obj.quickSort(arr, 0, n - 1);
            foreach (int i in arr) {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
}

// } Driver Code Ends


// User function Template for C#

class Solution {
    // Function to sort an array using quick sort algorithm.
    public void quickSort(int[] arr, int low, int high) {
        if (low < high) 
        {
            int pIndex = partition(arr, low, high);
            quickSort(arr, low, pIndex - 1);
            quickSort(arr, pIndex + 1, high);
        }
    }

    // Function to divide array into two parts and return the index.
    public int partition(int[] arr, int low, int high) {
          int i = low;
          int j = high;
          int pivot = arr[low];
        
          while (i < j){
        
              while (arr[i] <= pivot && i<=high-1){
                  i++;
              }
              while (arr[j] > pivot && j>=low + 1){
                  j--;
              }
        
            if (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    
        int temp2 = arr[low];
        arr[low] = arr[j];
        arr[j] = temp2;
    
        
          return j;
    }
}