public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n; 

        // Función para invertir una parte del array.
        void Reverse(int start, int end) {
            while (start < end) {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        // Invertir todo el array.
        Reverse(0, n - 1);
        // Invertir los primeros k elementos.
        Reverse(0, k - 1);
        // Invertir los elementos restantes.
        Reverse(k, n - 1);
    }
}
