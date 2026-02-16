public class Solution 
{
    public double FindMaxAverage(int[] nums, int k) 
    {
        double sum = 0;

        for (int i = 0; i < k; i++)
        {
        sum += nums[i];
        }
        
        double maxSum = sum;

        for (int i = k; i < nums.Length; i++)
        {
            sum = sum - nums[i - k] + nums[i];

            if (maxSum < sum)
            {
                maxSum = sum;
            }
        }

        return maxSum / k;
    }
}