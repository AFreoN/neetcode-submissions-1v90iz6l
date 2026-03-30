public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        StringBuilder sb = new StringBuilder();
        PriorityQueue<(char character,int count), int> pq = new PriorityQueue<(char,int), int>();
        if(a > 0) pq.Enqueue(('a', a), -a);
        if(b > 0) pq.Enqueue(('b', b), -b);
        if(c > 0) pq.Enqueue(('c', c), -c);

        char prev = ' ';
        int count = 0;
        while (pq.Count > 0)
        {
            var curr = pq.Dequeue();
            sb.Append(curr.character);
            curr.count--;
            if (prev == curr.character)
                count++;
            else
            {
                prev = curr.character;
                count = 1;
            }

            if (count == 2)
            {
                if (pq.Count == 0) break;
                var next = pq.Dequeue();
                sb.Append(next.character);
                next.count--;

                if(next.count > 0)
                    pq.Enqueue((next.character, next.count), -next.count);

                prev = next.character;
                count = 1;
            }

            if(curr.count > 0)
                pq.Enqueue((curr.character, curr.count), -curr.count);
        }

        return sb.ToString();
    }
}