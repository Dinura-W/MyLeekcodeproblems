public class Solution {
    public string ReverseVowels(string s) {

 
        char[] arrayS = s.ToCharArray();
        int start = 0;
        int end = s.Length - 1;
        string vowels = "aeiouAEIOU";
        char temp;
        string final = "";

        while (start < end)
        {
            while (start < end && !vowels.Contains(arrayS[start]))
                {
                    start++;
                }

            while (start < end && !vowels.Contains(arrayS[end]))
                {
                    end--;
                }

            temp = arrayS[end];
            arrayS[end] = arrayS[start];
            arrayS[start] = temp;
            start++;
            end--;
        }

        final = new string(arrayS);

        return final;
        


    }
}