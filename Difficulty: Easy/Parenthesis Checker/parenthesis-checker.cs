
class Solution {
    public bool isBalanced(string s) {
        Stack<char> st = new Stack<char>();
        
        foreach(char a in s){
            if(a=='(' || a=='{' || a=='['){
                st.Push(a);
            }
            else{
                if(st.Count==0) return false;
                else{
                    if((a==')' && st.Peek()=='(') || (a=='}' && st.Peek()=='{' ) || (a==']' && st.Peek()=='[')){
                        st.Pop();
                    }
                    else{
                        return false;
                    }
                }
            }
        }
        return st.Count==0 ? true : false;
    }
}