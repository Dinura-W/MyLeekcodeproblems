public class Solution {
    public int MaxVowels(string s, int k) {
        int max = 0;
        int finalmax = 0;
        for (int i = 0; i < k; i++)
        {
            

            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                max++;
            }
        }

        finalmax = max;

        for (int i = k; i < s.Length; i++)
        {

            if (s[i - k] == 'a' || s[i - k] == 'e' || s[i - k] == 'i' || s[i - k] == 'o' || s[i - k] == 'u')
            {
                max = max - 1;
            }

            if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
            {
                max = max + 1;
            }

            if (finalmax < max)
            {
                finalmax = max;
            }
        }
        
        return finalmax;
    }
}
