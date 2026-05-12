public class Solution {
    public int PivotIndex(int[] nums) {
        int i = 0;
        int TotalSum = 0;
        int LeftSum = 0;
        int Pivot = -1;

        while (i < nums.Length)
        {
            TotalSum = TotalSum + nums[i];
            i++;
        }


        for (i = 0; i < nums.Length; i++)
        {
            if (LeftSum == TotalSum - LeftSum - nums[i])
            {
                Pivot = i;
                break;
            }
            else
            {
                LeftSum = LeftSum + nums[i];
            }
        }
        

        return Pivot;
    }
}