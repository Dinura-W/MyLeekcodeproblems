public class Solution {
    public void MoveZeroes(int[] nums) {

        int temp;
        int writePointer = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                temp = nums[writePointer];
                nums[writePointer] = nums[i];
                nums[i] = temp;
                writePointer++;
            }
            

        }

        
    }
}