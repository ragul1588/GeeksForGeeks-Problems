class Solution {
    public int maxLen(int[] arr) {
       
         if (arr.length == 1) return 0;
         int sum = 0;
         int maxLen = 0;
         
        Map<Integer, Integer> map = new HashMap<>();
        
        for (int i=0; i<arr.length; i++) {
           int val = arr[i] == 0 ? -1 : 1;
           sum +=val;
           
           if(sum==0){
               maxLen = i+1;
           }
           if(map.containsKey(sum)){
              maxLen = Math.max(maxLen, i - map.get(sum));
           }else{
               map.put(sum,i);
           }
           
        }
    return maxLen;
    }
}