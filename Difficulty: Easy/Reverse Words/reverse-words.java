class Solution {
    // Function to reverse words in a given string
    public String reverseWords(String s) {
        // Code here
        Stack<String> stack = new Stack<>();
        String result = "";
        
        for (String word : s.trim().split("\\s+")) {
            if (!word.isEmpty()) {
                stack.push(word);
            }
        }
        while(stack.size() !=1){
            result += stack.pop()+" ";
        }
        result +=stack.pop();
         return result;
    }
}
