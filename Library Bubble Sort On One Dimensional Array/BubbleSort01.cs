// Link to the problem: https://leetcode.com/problems/move-zeroes/

namespace LibraryBubbleSort
{
    public class BubbleSort01
    {
        public static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length -1; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] is 0)
                    {
                        int aux = nums[i];
                        nums[i] = nums[j];
                        nums[j] = aux;
                    }
                }
            }
        }
    }
}
