
public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] highest = new bool[candies.Length];
        for (int i = 0; i < candies.Length; i++)
        {
        if (candies.Max() <= candies[i] + extraCandies)
        {
        highest[i] = true;
        }
        else
        {
        highest[i] = false;
        }
        }

    return highest;


    }
}