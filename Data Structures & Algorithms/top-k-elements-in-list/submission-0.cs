public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
      {
        var dict = new Dictionary<int, int>();

        foreach (var n in nums)
        {
        if (dict.ContainsKey(n)) dict[n] += 1;
        else dict.Add(n, 1);
        }

        var queue = new PriorityQueue<int, int>();

        foreach (var kv in dict)
        {
        queue.Enqueue(kv.Key, kv.Value);
        if (queue.Count > k) queue.Dequeue();
        }
        var res = new int[k];

        for (int i = 0; i < k; i++) res[i] = queue.Dequeue();
        return res;
    }

}
