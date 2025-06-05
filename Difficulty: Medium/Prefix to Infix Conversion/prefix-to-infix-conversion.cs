// User function Template for C#

class Solution {
    // Complete this function
    // Function to convert prefix expression to infix expression.
    public string preToInfix(string pre_exp) {
       
       Stack<string> st =  new Stack<string>();
       char[] input = pre_exp.ToCharArray();
       int size = input.Length-1;
       
       for(int i=size; i>=0; i--){
           if(char.IsLetterOrDigit(input[i])){
               st.Push(input[i].ToString());
           }
           else{
               string temp = "(" + st.Pop() + input[i] + st.Pop() + ")";
               st.Push(temp);
           }
       }
        return st.Pop();
    }
}