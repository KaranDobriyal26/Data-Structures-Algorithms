// Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.

// There is only one repeated number in nums, return this repeated number.

// You must solve the problem without modifying the array nums and uses only constant extra space.

 

// Example 1:

// Input: nums = [1,3,4,2,2]
// Output: 2
// Example 2:

// Input: nums = [3,1,3,4,2]
// Output: 3
 

// Constraints:

// 1 <= n <= 105
// nums.length == n + 1
// 1 <= nums[i] <= n
// All the integers in nums appear only once except for precisely one integer which appears two or more times.

class Solution
{
    public static void Main(string[] args)
    {
        int[] nums = {1,3,4,2,2};
         int ans = 0;

         // 1. Approach but it will give O(nLogn).
          Array.Sort(nums);
        for(int i=0; i<nums.Length-1; i++)
        {
            if(nums[i] == nums[i+1])
            {
                ans = nums[i];
                break;
            }
        }
        Console.WriteLine(ans);

        // 2. Linear Way O(N).
          int n = nums.Length;
        int[] freq = new int[n + 1];
        for (int i = 0; i < n; i++) {
            if (freq[nums[i]] == 0) {
                freq[nums[i]] += 1;
            } else {
                ans =nums[i];
            }
        }
        Console.WriteLine(ans);
    }
}