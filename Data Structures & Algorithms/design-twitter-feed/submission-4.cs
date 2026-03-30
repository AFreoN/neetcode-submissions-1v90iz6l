public class Tweet
{
    public int tweetId;
    public int postCount;
    public Tweet? next = null;
    public Tweet(int tweetId, int postCount, Tweet? next = null)
    {
        this.tweetId = tweetId;
        this.postCount = postCount;
        this.next = next;
    }
}
public class Twitter
{
    const int FEED_COUNT = 10;
    int count;
    Dictionary<int, Tweet> tweetMap;
    Dictionary<int, HashSet<int>> followMap;
    public Twitter()
    {
        count = 0;
        tweetMap = new Dictionary<int, Tweet>();
        followMap = new Dictionary<int, HashSet<int>>();
    }

    public void PostTweet(int userId, int tweetId)
    {
        count++;
        tweetMap.TryGetValue(userId, out var head);
        tweetMap[userId] = new Tweet(tweetId, count, head);
    }

    public List<int> GetNewsFeed(int userId)
    {
        List<int> output = new List<int> ();
        var pq = new PriorityQueue<Tweet, int>();

        if (tweetMap.TryGetValue(userId, out var tweet)) //add tweet of this user
            pq.Enqueue(tweet, -tweet.postCount);

        //Get all followers and their first tweet, add to priority enqueue
        if(followMap.TryGetValue(userId, out var followers))
        {
            foreach (var follower in followers)
            {
                if (follower == userId || tweetMap.TryGetValue(follower, out tweet) == false) continue;
                pq.Enqueue(tweet, -tweet.postCount);
            }
        }

        //Loop through each followers, get their latest, dequeue and add to the output
        while(pq.Count > 0 && output.Count < FEED_COUNT)
        {
            var t = pq.Dequeue();
            output.Add(t.tweetId);
            if (t.next == null) continue;
            pq.Enqueue(t.next, -t.next.postCount);
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