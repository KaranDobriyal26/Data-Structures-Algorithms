public class Solution {
    public static void Main(String[] args) {
        // Set the Kth Set bit.
        int n = 5;
        int k = 1;
        Console.WriteLine(SetTheKthBit(n,k));
    }
    static int SetTheKthBit(int n, int k)
    {
        int mask = 1 << k;
        n |= mask;
        return n;
    }
}