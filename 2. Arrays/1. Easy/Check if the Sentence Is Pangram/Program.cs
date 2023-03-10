// A pangram is a sentence where every letter of the English alphabet appears at least once.

// Given a string sentence containing only lowercase English letters, return true if sentence is a pangram, or false otherwise.

 

// Example 1:

// Input: sentence = "thequickbrownfoxjumpsoverthelazydog"
// Output: true
// Explanation: sentence contains at least one of every letter of the English alphabet.
// Example 2:

// Input: sentence = "leetcode"
// Output: false
 

// Constraints:

// 1 <= sentence.length <= 1000
// sentence consists of lowercase English letters.

public class Solution {

    public static void Main(string[] args)
    {
        string sentence = "abcdkaran";
        Console.WriteLine(CheckIfPangram(sentence));

        // 1. Approach
        // foreach (char ch in "abcdefghijklmnopqrstuvwxyz".AsSpan())
        // {
        //     if (!sentence.Contains(ch)) 
        //     {
        //         return false;
        //     } 
        // }

        // return true;    
 

    }

     public static  bool  CheckIfPangram(string sentence) { 
        string[] AllApha = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t"
        ,"u","v","w","x","y","z"};
        int[] ans = new int[26];
        bool hasSeen = false;
        bool myAns = true;
        for(int i=0; i<sentence.Length; i++)
        {   
            for(int j=0; j<AllApha.Length; j++)
            {
                if(AllApha[j].ToString() == sentence[i].ToString())
                {
                    hasSeen = true;
                     ans[j] = -1; 
                }
            }
            
        }

        foreach(int i in ans)
        {
             if(i == 0) myAns = false;
        }
        return myAns;
    }
}