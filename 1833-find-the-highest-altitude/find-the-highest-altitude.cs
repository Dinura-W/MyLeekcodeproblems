public class Solution {
    public int LargestAltitude(int[] gain) {
        int n = 0;
        int tempalt = 0;
        int alt = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            tempalt = tempalt + gain[i];

            if (alt < tempalt)
            {
                alt = tempalt;
            }
        }


        return alt;
    }
}