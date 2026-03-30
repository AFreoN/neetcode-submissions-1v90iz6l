public class Solution {
    public bool LemonadeChange(int[] bills) {
        int fives = 0, tens = 0;

        foreach(int v in bills)
        {
            if(v == 5) fives++;
            else if(v == 10)
            {
                tens++;
                if(fives > 0) fives--;
                else return false;
            }
            else if(v == 20)
            {
                if(tens > 0 && fives > 0)
                {
                    tens--;
                    fives--;
                }
                else if(fives >= 3) fives -= 3;
                else return false;
            }
        }

        return true;
    }
}