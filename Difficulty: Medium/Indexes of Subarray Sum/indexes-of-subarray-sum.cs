class Solution {
    public List<int> SubarraySum(int[] arr, int target) {
        
        if(arr == null || arr.Length==0)  new List<int> {-1};
        int result = 0;
        int n = arr.Length;
        for(int i=0; i<n; i++){
            result=0;
            for(int j=i; j<n; j++){
                result +=arr[j];
                if(result == target) return new List<int> {i+1, j+1};
            }
        }
        return new List<int> {-1};
    }
}