public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0) return 0;
        bool[] visited = new bool[amount + 1];
        int steps = 0;
        Queue<int> q = new Queue<int>();
        q.Enqueue(0);
        while(q.Count > 0)
        {
            steps++;
            int qCount = q.Count;
            for(int i = 0; i < qCount; i++)
            {
                int currAmount = q.Dequeue();
                foreach(int coin in coins)
                {
                    int sum = currAmount + coin;
                    if(sum == amount) return steps;
                    if(sum > amount || visited[sum]) continue;
                    visited[sum] = true;
                    q.Enqueue(sum);
                }
            }
        }
        return -1;
    }
}
