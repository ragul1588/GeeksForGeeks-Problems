class Solution {
    public List<int> calculateSpan(int[] arr) {
        
        int n = arr.Length;
        Stack<int> st = new Stack<int>();
        List<int> result = new List<int>();
        
        for(int i=0; i<n; i++){
            
            while(st.Count>0 && arr[st.Peek()]<=arr[i]){
                st.Pop();
            }
            int val = st.Count == 0 ? (i+1) : (i-st.Peek());
            result.Add(val);
            st.Push(i);
        }
        return result;
    }
}