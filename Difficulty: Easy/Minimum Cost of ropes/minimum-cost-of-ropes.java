class Solution {
    public static int minCost(int[] arr) {
        PriorityQueue<Integer> pq = new PriorityQueue<>();

       if(arr.length==1) return 0;
        for (int val : arr) {
            pq.add(val);
        }

        int totalCost = 0;

       
        while (pq.size() > 1) {
            int sum = pq.poll() + pq.poll();
            totalCost += sum;
            pq.add(sum);
        }

        return totalCost;
        
    }
}