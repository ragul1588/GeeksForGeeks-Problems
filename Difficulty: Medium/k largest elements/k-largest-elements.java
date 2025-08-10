class Solution {
    public ArrayList<Integer> kLargest(int[] arr, int k) {
      
       // Min-heap to store top k largest elements
        PriorityQueue<Integer> pq = new PriorityQueue<>();

        for (int a : arr) {
            pq.offer(a);
            if (pq.size() > k) {
                pq.poll();
            }
        }

        // Reverse order using a stack
        Stack<Integer> st = new Stack<>();
        while (!pq.isEmpty()) {
            st.push(pq.poll());
        }

        ArrayList<Integer> result = new ArrayList<>();
        while (!st.isEmpty()) {
            result.add(st.pop());
        }

        return result;
    }
}
