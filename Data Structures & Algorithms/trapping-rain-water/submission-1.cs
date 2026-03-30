public class Solution {
    public int Trap(int[] height) {
            int total = height.Length;
            if (total <= 2) return 0;
            int result = 0;
            int l = 0, r = 1, max = height[0], blocks = 0, width = 0;
            while(r < height.Length)
            {
                int lh = height[l], rh = height[r];
                if (rh >= max)
                {
                    //fill the water here (removing blocks) & move the left pointer to here, right to one further
                    result += max * width - blocks;
                    blocks = 0; width = 0; max = rh;
                    l = r;
                    r++;
                }
                else
                {
                    // compute blocks, increase the right pointer
                    blocks += height[r];
                    width++;
                    r++;
                }
            }
            int w = width; 
            max = height[total - 1]; width = 0; blocks = 0; l = total - 2; r = total - 1;
            for(int i = 0; i < w; i++)
            {
                int lh = height[l], rh = height[r];
                if(lh >= max)
                {
                    result += max * width - blocks;
                    blocks = 0; width = 0; max = lh;
                    r = l;
                    l--;
                }
                else
                {
                    blocks += lh;
                    width++;
                    l--;
                }
            }
            return result;
    }
}
