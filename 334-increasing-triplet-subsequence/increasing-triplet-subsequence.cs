public class Solution {
    public bool IncreasingTriplet(int[] nums) {

        var first = int.MaxValue;
        var mid = int.MaxValue;

        bool Output = false;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < first)
            {
                first = nums[i];
            }
            else if (nums[i] < mid && nums[i] != first)
            {
                mid = nums[i];
            }
            else if (nums[i] > mid)
            {
                Output = true;
            }
        }

        return Output;
    }
}