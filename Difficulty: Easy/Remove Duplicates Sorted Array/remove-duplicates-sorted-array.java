class Solution {
    // Function to remove duplicates from the given array
    public int removeDuplicates(int[] arr) {
       
       if(arr.length==1) return 1;
       int j=0;
       
       for(int i=1; i<arr.length; i++){
           if(arr[i] !=arr[j]) {
               j++;
               arr[j] = arr[i];
           }
       }
       return j+1;
        
    }
}