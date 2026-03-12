public class Solution {
    public string ReverseWords(string s) {

        int l = s.Length - 1;
        string reverse = "";
        string finalreverse = "";

            while (0 <= l)
            {
                while (0 <= l  && s[l] != ' ')
                    {
                        reverse = s[l] + reverse;
                        l = l - 1;
                    }


            if (reverse != "")
            {
                finalreverse = finalreverse == "" ? reverse : finalreverse + " " + reverse;
                reverse = "";
            }


                while (0 <= l && s[l] == ' ')
                    {
                        if (0 <= l)
                            {
                                l = l - 1;  
                            }
                        else
                            {
                                break;
                            }
                    }
            }




        return finalreverse;
    }
}