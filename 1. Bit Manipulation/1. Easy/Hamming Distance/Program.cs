// The Hamming distance between two integers is the number of positions at which the corresponding bits are different.

// Given two integers x and y, return the Hamming distance between them.

// Example 1:

// Input: x = 1, y = 4
// Output: 2
// Explanation:
// 1   (0 0 0 1)
// 4   (0 1 0 0)
//        ↑   ↑
// The above arrows point to positions where the corresponding bits are different.
// Example 2:

// Input: x = 3, y = 1
// Output: 1
 

// Constraints:

// 0 <= x, y <= 231 - 1

public class Solution {
    public static void Main(String[] args) {

        int x = 2;
        int y = 7;
        Console.WriteLine(getHammingDistance(x,y));
    }
    static int getHammingDistance(int x, int y)
    {
        int counter = 0;
//        int ans = x^y;
//        while(ans !=0)
//        {
//            ans&=ans-1;
//            counter++;
//        }
//        return counter;

        // Another Approach.
        while(x !=0 || y!=0)
        {
            if((x&1) != (y&1))
            {
                counter++;
            }
            x>>=1;
            y>>=1;
        }
        return counter;
    }
}