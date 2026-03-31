class Solution {
    public int maxSubarraySum(int[] arr, int k) {
        // Code here
        int maxSum = int.MinValue, sum = 0, right =0, left = 0;
        
        while(right<arr.Length){
            
            sum +=arr[right];
            
            if(right-left+1>k){
                sum -=arr[left];
                left++;
            }
            if(right-left+1 == k){
                maxSum = Math.Max(maxSum, sum);
            }
            right++;
        }
        return maxSum;
    }
}