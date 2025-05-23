class Solution {
    public int[] nextLargerElement(int[] arr) {
        
     int n = arr.Length;
     int[] result = new int[n];
     Stack<int> st = new Stack<int>();
     
     for(int i=n-1; i>=0; i--){
         
         while(st.Count>0 && st.Peek()<=arr[i]){
             st.Pop();
         }
         int val = st.Count == 0 ? -1 : st.Peek();
         result[i] = val;
         st.Push(arr[i]);
     }
    return result;
    }
}