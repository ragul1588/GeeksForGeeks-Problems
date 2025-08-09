class Solution {
    public string MinWindow(string s1, string s2) {
        
        int n = s1.Length, m = s2.Length, minLen = Int32.MaxValue, index = -1;
        
        //Optimal solution
     
         for(int i=0; i<n; i++){
             
             int j=i;
             int t=0;
             
                while(j<n && t<m){
                    if(s1[j] == s2[t]) t++;
                    
                    j++;
                }
                
                if(t==m){
                    int end = j-1;
                    int p = end;
                    int k = m-1;
                    
                    while(k>=0){
                        if(s1[p]==s2[k]) k--;
                        
                        p--;
                    }
                    
                    if(k == -1){
                        int start = p+1;
                        if(end-start+1<minLen){
                            minLen = end-start+1;
                            index = start;
                        }
                    }
                }
                
             }
        
        return index == -1 ? "" : s1.Substring(index,minLen);
        
    }
}
