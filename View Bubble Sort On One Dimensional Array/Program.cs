using LibraryBubbleSort;


// Bubble Sort 01
int[] nums = [0, 1, 0, 3, 12];
BubbleSort01.MoveZeroes(nums);

for (int i = 0; i < nums.Length; i++)
    Console.Write($" {nums[i].ToString()}");

