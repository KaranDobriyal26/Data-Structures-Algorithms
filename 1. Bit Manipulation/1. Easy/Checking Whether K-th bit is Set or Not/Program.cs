public class Solution {
    public static void Main(String[] args) {
        int n = 5; // 101;
        int k = 1; // 001;
       Console.WriteLine(isSetBit(n,k));
    }

    static bool isSetBit(int n, int k)
    {
         // 1. Approach Using Masking
        return ((n & (1<<k)) >0);

        // 2. Approach is Using right Shift.
        //return (((n>>k)&1)==1);
    }
}