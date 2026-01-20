public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string newword = "";
        int n = 0;
        if (word1.Length > word2.Length)
        {

            for (int i = 0; i < word2.Length; i++)
            {
            newword = newword + word1[i] + word2[i];
            n = i + 1;
            }
            while(n < word1.Length)
            {  
            newword = newword + word1[n];
            n++;
            }


        }
        else if (word1.Length < word2.Length) 
        {
            for (int i = 0; i < word1.Length; i++)
            {
            newword = newword + word1[i] + word2[i];
            n = i + 1;
            }
            while(n < word2.Length)
            {  
            newword = newword + word2[n];
            n++;
            }
        }
        else
        {
            for (int i = 0; i < word1.Length; i++)
            {
            newword = newword + word1[i] + word2[i];
            }  
        }

    return newword;   
    }

    
    
}