public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
    int f = 0;
    bool d = false;
    if (flowerbed.Length == 1)
        {
        if (flowerbed[f] == 1)
            {
            f = 0;    
            }
        else if (flowerbed[f] == 0)
        {
        f = 1;  
        }
        
    }
    else 
    {
    
       for (int i = 0; i < flowerbed.Length; i++) 
       {


        if (i == 0)
        {
          if (flowerbed[i + 1] == 0 && flowerbed[i] == 0)
          {
            f++;
            flowerbed[i] = 1;
          }    
        }


        else if (i == flowerbed.Length - 1)
        {
           if (flowerbed[i] == 0 && flowerbed[i - 1] == 0)
           {
            f++;    
            flowerbed[i] = 1;
           }
        }

        else if (flowerbed[i + 1] == 0 && i != 0)
        {
            if (flowerbed[i - 1] == 0 && flowerbed[i] == 0)
            {
            f++;
            flowerbed[i] = 1;
            }
        }

       }
    }
        if (n <= f)
       {
        d = true;
       }

       return d;
    }
}