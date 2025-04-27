//{ Driver Code Starts
import java.util.*;

class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int t = Integer.parseInt(sc.nextLine());

        while (t-- > 0) {
            int n = Integer.parseInt(sc.nextLine());
            int[][] maze = new int[n][n];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    maze[i][j] = sc.nextInt();
                }
            }

            if (sc.hasNextLine()) sc.nextLine();

            Solution obj = new Solution();
            ArrayList<String> result = obj.ratInMaze(maze);

            if (result.isEmpty()) {
                System.out.print("[]");
            } else {
                for (String path : result) {
                    System.out.print(path + " ");
                }
            }
            System.out.println();
            System.out.println("~");
        }

        sc.close();
    }
}

// } Driver Code Ends


// User function Template for Java

class Solution {
    // Function to find all possible paths
    public ArrayList<String> ratInMaze(int[][] maze) {
        
        int n = maze[0].length;
        ArrayList<String> res = new ArrayList<>();
        
        int[][] visited = new int[n][n];
        int[] calcI = {1,0,0,-1};
        int[] calcJ = {0,-1,1,0};
        
        if(maze[0][0]==1){
            visited[0][0] = 1;
            solve(0,0, n,calcI, calcJ, "", maze, visited, res);
        }
        
        return res;
        
    }
     // Recursive backtracking function
    static void solve(int i, int j, int n, int[] calcI, int[] calcJ, String s, int[][] val, int[][] visited, List<String> res) {
        if (i == n - 1 && j == n - 1) {
            res.add(s);
            return;
        }

        String dir = "DLRU";

        for (int ind = 0; ind < 4; ind++) {
            int nextI = i + calcI[ind];
            int nextJ = j + calcJ[ind];

            if (nextI >= 0 && nextI < n && nextJ >= 0 && nextJ < n
                    && visited[nextI][nextJ] == 0 && val[nextI][nextJ] == 1) {
                visited[nextI][nextJ] = 1;
                solve(nextI, nextJ, n, calcI, calcJ, s + dir.charAt(ind), val, visited, res);
                visited[nextI][nextJ] = 0;
            }
        }
    }
}