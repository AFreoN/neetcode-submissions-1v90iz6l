public class Solution {
    public int FindJudge(int n, int[][] trust) {
        Span<int> freq = stackalloc int[n+1];
        foreach(var item in trust){
            freq[item[0]]--;
            freq[item[1]]++;
        }

        for(int i = 1; i <= n; i++)
            if(freq[i] == n - 1)
                return i;

        return -1;
    }
}