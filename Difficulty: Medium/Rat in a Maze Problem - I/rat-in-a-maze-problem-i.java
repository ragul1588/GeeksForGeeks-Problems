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
        
        if(maze[0][0]==1){
            visited[0][0] = 1;
            solve(0,0, n, "", maze, visited, res);
        }
        
        return res;
        
    }
     // Recursive backtracking function
    public void solve(int i, int j, int n, String path, int[][] maze, int[][] visited, List<String> res) {
        if (i == n - 1 && j == n - 1) {
            res.add(path);
            return;
        }

        // Move Down
        if (i + 1 < n && maze[i + 1][j] == 1 && visited[i + 1][j] == 0) {
            visited[i + 1][j] = 1;
            solve(i + 1, j, n, path + "D", maze, visited, res);
            visited[i + 1][j] = 0;
        }

        // Move Left
        if (j - 1 >= 0 && maze[i][j - 1] == 1 && visited[i][j - 1] == 0) {
            visited[i][j - 1] = 1;
            solve(i, j - 1, n, path + "L", maze, visited, res);
            visited[i][j - 1] = 0;
        }

        // Move Right
        if (j + 1 < n && maze[i][j + 1] == 1 && visited[i][j + 1] == 0) {
            visited[i][j + 1] = 1;
            solve(i, j + 1, n, path + "R", maze, visited, res);
            visited[i][j + 1] = 0;
        }

        // Move Up
        if (i - 1 >= 0 && maze[i - 1][j] == 1 && visited[i - 1][j] == 0) {
            visited[i - 1][j] = 1;
            solve(i - 1, j, n, path + "U", maze, visited, res);
            visited[i - 1][j] = 0;
        }
    }
}