// User function template for C#

class Solution {
    // Function to return the count of the number of elements in
    // the intersection of two arrays.
    public int numberofElementsInIntersection(int[] a, int[] b) {
         HashSet<int> set = new HashSet<int>();
         int count = 0;
        foreach(int val in a) set.Add(val);
        
        foreach(int val in b) {
           if(set.Contains(val)){
               count++;
           }   
        }
        return count;
    }
}