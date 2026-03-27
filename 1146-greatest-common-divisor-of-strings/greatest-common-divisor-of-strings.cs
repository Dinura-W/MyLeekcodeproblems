public class Solution {
    public string GcdOfStrings(string str1, string str2) {

        if (str1 + str2 != str2 + str1) {return "";}

        int len1 = str1.Length;
        int len2 = str2.Length;
        int gcdLength;



        while (len2 != 0)
        {
            gcdLength = len1 % len2;
            len1 = len2;
            len2 = gcdLength;
        }

        gcdLength = len1;

        string gcd = str1.Substring(0, gcdLength);

        return gcd;
        
    }
}