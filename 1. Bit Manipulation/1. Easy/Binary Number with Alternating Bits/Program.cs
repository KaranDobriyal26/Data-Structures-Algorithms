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