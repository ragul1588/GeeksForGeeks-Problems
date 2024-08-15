//{ Driver Code Starts
import java.io.*;
import java.util.*;

class GFG {
    public static void main(String args[]) throws IOException {
        BufferedReader read =
            new BufferedReader(new InputStreamReader(System.in));
        int t = Integer.parseInt(read.readLine());
        while (t-- > 0) {
            String S[] = read.readLine().split(" ");
            Long A = Long.parseLong(S[0]);
            Long B = Long.parseLong(S[1]);

            Solution ob = new Solution();
            Long[] ptr = ob.lcmAndGcd(A,B);
            
            System.out.print(ptr[0]);
            System.out.print(" ");
            System.out.println(ptr[1]);
        }
    }
}
// } Driver Code Ends


class Solution {
    static Long[] lcmAndGcd(Long A , Long B) {
       
        
        Long[] val = new Long[2];
        val[0] = LCM(A,B);
        val[1] = GCD(A,B);
    
        return val;
    }
    
    static Long LCM(Long a,Long b){
            return a*b/GCD(a,b);
        }
    
     static Long GCD(Long a,Long b){
            while(b!=0){
                Long temp = b;
                b= a%b;
                a=temp;
            }
            return a;
        }
};