class Solution {
    public string infixToPostfix(string s) {
       
       StringBuilder result = new StringBuilder();
       Stack<char> st = new Stack<char>();
       
       foreach(char a in s){
         if(Char.IsLetterOrDigit(a)){
             result.Append(a);
         }
         else if(a == '('){
             st.Push(a);
         }
         else if(a == ')'){
             while(st.Count>0 && st.Peek() !='('){
                 result.Append(st.Pop());
             }
             st.Pop();
         }
         else{
             while(st.Count>0 && priority(a)<=priority(st.Peek())){
                 result.Append(st.Pop());
             }
             st.Push(a);
         }
       }
       while(st.Count>0) result.Append(st.Pop());
       
        return result.ToString();
    }
    
    public int priority(char val){
        if(val == '^') return 3;
        else if(val == '*' || val == '/') return 2;
        else if(val == '+' || val == '-') return 1;
        
        return -1;
    }
}