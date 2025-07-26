class Solution {
      int countTriplet(int[] arr) {
        Arrays.sort(arr);  // Sort the array first
        int count = 0;
        int n = arr.length;
        // Fix the third element one by one from the end
        for (int k = n - 1; k >= 2; k--) {
            int i = 0;
            int j = k - 1;

            while (i < j) {
                int sum = arr[i] + arr[j];

                if (sum == arr[k]) {
                    count++;
                    i++;
                    j--;
                } else if (sum < arr[k]) {
                    i++;
                } else {
                    j--;
                }
            }
        }

        return count;
    }
}