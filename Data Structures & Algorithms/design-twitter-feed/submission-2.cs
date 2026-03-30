public class Twitter
{
    const int FEED_COUNT = 10;
    int count;
    Dictionary<int, List<(int tweetId, int postCount)>> tweetMap;
    Dictionary<int, HashSet<int>> followMap;
    public Twitter()
    {
        count = 0;
        tweetMap = new Dictionary<int, List<(int tweetId, int postCount)>>();
        followMap = new Dictionary<int, HashSet<int>>();
    }

    public void PostTweet(int userId, int tweetId)
    {
        tweetMap.TryAdd(userId, new List<(int tweetId, int postCount)>());
        tweetMap[userId].Add((tweetId, ++count));
    }

    public List<int> GetNewsFeed(int userId)
    {
        List<int> output = new List<int> ();
        var pq = new PriorityQueue<(int tweet, int user, int idx), int>();

        if (tweetMap.TryGetValue(userId, out var tweet) && tweet.Count > 0) //add tweet of this user
        {
            int id = tweet.Count - 1;
            pq.Enqueue((tweet[id].tweetId, userId, id), -tweet[id].postCount);
        }

        //Get all followers and their first tweet, add to priority enqueue
        if(followMap.TryGetValue(userId, out var followers))
        {
            foreach (var follower in followers)
            {
                if (follower == userId || tweetMap.TryGetValue(follower, out tweet) == false || tweet.Count == 0) continue;
                int noOfTweets = tweet.Count - 1;
                pq.Enqueue((tweet[noOfTweets].tweetId, follower, noOfTweets), -tweet[noOfTweets].postCount);
            }
        }

        //Loop through each followers, get their latest, dequeue and add to the output
        while(pq.Count > 0 && output.Count < FEED_COUNT)
        {
            var v = pq.Dequeue();
            output.Add(v.tweet);
            int idx = v.idx - 1;
            if (idx < 0) continue;
            var tweets = tweetMap[v.user];
            pq.Enqueue((tweets[idx].tweetId, v.user, idx), -tweets[idx].postCount);
        }
        return output;
    }

    public void Follow(int followerId, int followeeId)
    {
        followMap.TryAdd(followerId, new HashSet<int>());
        followMap[followerId].Add(followeeId);
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (followMap.ContainsKey(followerId)) 
            followMap[followerId].Remove(followeeId);
    }
}