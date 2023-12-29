namespace LeetCode;

public class _1046_LastStoneWeight
{
    public int LastStoneWeight(int[] stones) {
        var queue = new PriorityQueue<int, int>(stones.Select(x => (x,-x)));

        while(queue.Count>=2)
        {
            int a = queue.Dequeue();
            int b = queue.Dequeue();
            int dif;
            if ((dif = Math.Abs(a-b)) > 0)
                queue.Enqueue(dif,-dif);
        }
        
        if (queue.Count == 0)
            return 0;
        else
            return queue.Dequeue();
    }
}