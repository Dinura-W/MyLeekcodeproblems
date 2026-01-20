public class Solution {
    public bool IsSubsequence(string s, string t) {
        string word = "";
        int n = 0;
        for (int i = 0; i < s.Length; i++)
        {
            while (n < t.Length)
            {
                if (s[i] == t[n])
                {
                word = word + s[i];
                break;
                }
                else
                {
                n++;
                }
            }
        n = n + 1;
        }
    if (word == s)
    {
        return true;
    }
    else
    {
        return false;
    }    
    }
}