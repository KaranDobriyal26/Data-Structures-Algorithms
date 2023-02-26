// Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n), ans[i] is the number of 1's in the binary representation of i.

 

// Example 1:

// Input: n = 2
// Output: [0,1,1]
// Explanation:
// 0 --> 0
// 1 --> 1
// 2 --> 10
// Example 2:

// Input: n = 5
// Output: [0,1,1,2,1,2]
// Explanation:
// 0 --> 0
// 1 --> 1
// 2 --> 10
// 3 --> 11
// 4 --> 100
// 5 --> 101

public class Solution {
    public static void Main(String[] args) {
        int n = 5;
        int[] res = new int[n];
        res = CountingBitsAndStoreToArray(n+1);
        for(int i=0; i<res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
    static int[] CountingBitsAndStoreToArray(int n)
    {
        int[] passArray = new int[n];
        // 1. First Approach with O(NLogN).

//        int counter = 0;
//        // 1. traverse the passArray
//        for(int i=0; i<passArray.length; i++)
//        {
//            int temp = i;
//            while(temp != 0)
//            {
//                temp&=temp-1;
//                counter++;
//            }
//            passArray[i] = counter;
//            counter = 0;
//        }

        // 2. Second Approach with O(N).

//        for(int i=0; i<n; i++)
//        {
//            // if it is even
//            if((i & 1) == 0)
//            {
//                passArray[i] = passArray[i/2];
//            }
//            else // if i is odd
//            {
//                passArray[i] = passArray[i/2] + 1;
//            }
//        }

        // 3. Approach
        for(int i=0; i<n; i++)
        {
            passArray[i] = passArray[i>>1] + (i%2);
        }

        return passArray;
    }
}