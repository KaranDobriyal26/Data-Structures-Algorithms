﻿// Given a positive integer, check whether it has alternating bits: namely, if two adjacent bits will always have different values.

// Example 1:

// Input: n = 5
// Output: true
// Explanation: The binary representation of 5 is: 101
// Example 2:

// Input: n = 7
// Output: false
// Explanation: The binary representation of 7 is: 111.
// Example 3:

// Input: n = 11
// Output: false
// Explanation: The binary representation of 11 is: 1011.


public class Solution {
    public static void Main(String[] args)
    {
         int n = 7;
         Console.WriteLine(hasAlternateBits(n));
    }
        static bool hasAlternateBits(int n)
        {
            bool res = true;
            while(n!=0)
            {
                int a = (n&1);
                int b = ((n>>1) & 1);
                if(a == b)
                {
                    res = false;
                    break;
                }
               n>>=1;
            }
            return res;
        }
}