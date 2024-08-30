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

                int n = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[n];

                string elements = Console.ReadLine().Trim();
                elements = elements + " " + "0";
                arr = Array.ConvertAll(elements.Split(), int.Parse);

                Solution obj = new Solution();
                obj.insertionSort(arr, n);
                printArray(arr, n);
            }

        }
        static public void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
// } Driver Code Ends


//User function Template for C#

public class Solution
{
    //Function to insert an element at the given index in the array.
    public void insert(int[] arr, int i)
    {
       
            int key = arr[i];
            int j = i-1;
            
            while(j>=0 && arr[j]>key){
                arr[j+1] = arr[j];
                j = j-1;
            }
            arr[j+1] = key;
    }
    
    //Function to sort the array using insertion sort algorithm.
    public void insertionSort(int[] arr, int n)
    {
         for(int i =1; i<arr.Length-1; i++){
             insert(arr, i);
         }
    }
}