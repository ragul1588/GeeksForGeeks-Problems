public class Solution {
    // Function to check if a string is a palindrome
    public bool isPalindrome(string s) {
       int n = s.Length;
       int high = n-1;
       for(int i=0; i<n; i++){
           while(s[i] !=s[high]){
               return false;
           }
           high--;
       }
       return true;
    }
}