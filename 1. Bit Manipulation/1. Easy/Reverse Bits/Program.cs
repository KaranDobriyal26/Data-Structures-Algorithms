using System.Runtime.ConstrainedExecution;
// Reverse bits of a given 32 bits unsigned integer.
 
// Example 1:

// Input: n = 00000010100101000001111010011100
// Output:    964176192 (00111001011110000010100101000000)
// Explanation: The input binary string 00000010100101000001111010011100 represents the unsigned integer 43261596, so return 964176192 which its binary representation is 00111001011110000010100101000000.
// Example 2:

// Input: n = 11111111111111111111111111111101
// Output:   3221225471 (10111111111111111111111111111111)
// Explanation: The input binary string 11111111111111111111111111111101 represents the unsigned integer 4294967293, so return 3221225471 which its binary representation is 10111111111111111111111111111111.
 

// Constraints:

// The input must be a binary string of length 32

class Solution
{
    public static void Main(string[] args)
    {
        string n = "110";
        Console.WriteLine(reversBits(n));
    }
    static string reversBits(string n)
    {
        string ans = "";
        
        // 1. Approach reverse the string by backward loop.
        int len = n.Length-1;
       
        for(int i=len; i>=0; i--)
        {
            ans+=n[i].ToString();
        } 

        // 2. Approach, here n is Uint.
        uint num = Convert.ToUInt32(n);
        num = ((num & 0xffff0000) >> 16) | ((num & 0x0000ffff) << 16);
        num = ((num & 0xff00ff00) >> 8) | ((num & 0x00ff00ff) << 8);
        num = ((num & 0xf0f0f0f0) >> 4) | ((num & 0x0f0f0f0f) << 4);
        num = ((num & 0xcccccccc) >> 2) | ((num & 0x33333333) << 2);
        num = ((num & 0xaaaaaaaa) >> 1) | ((num & 0x55555555) << 1);
        
       // return num;

        // 3. Approach
         int res =0;
         int re = Convert.ToInt32(n);
         for(int i =0;i<32;i++) {
            //this is used to find least significant digit (lsb)
            // 00000010100101000001111010011100 & 1 = 00000010100101000001111010011100<- lsb =0
            int lsb = re & 1;

            // soo, left shift of lsb lsb<<(31-i) so our 1st position zero will swaped with 31-i.so on...
            int revLsb = lsb<<(31-i);
           // store the revLsb in our result variable 
            res = res|revLsb;

            // right sift of n , one time ans soo on...
            re= re>>1;
        }
        return ans; // can return num or return res. depends which approach we follow.
    }
}