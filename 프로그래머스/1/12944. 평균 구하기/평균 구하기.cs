public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        int sum = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        double average = (double)sum / arr.Length;
        return average;
    }
}