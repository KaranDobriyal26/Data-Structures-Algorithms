public class Solution {
    public static void Main(String[] args) {

        int n = 11;
        int k = 4;
        Console.WriteLine(ClearSetBit(n,k));
    }
    static int ClearSetBit(int n, int k)
    {
        n = n & (~(1<<k-1));
        return n;
    }
}