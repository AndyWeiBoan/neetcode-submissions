public class Solution {
    public int LongestConsecutive(int[] nums) {
        var hashset = new HashSet<int>(nums);

    var res = 0;
    foreach (var h in hashset)
    {
      if (hashset.Contains(h - 1)) continue;

      var count = 0;
      for (int i = h; ; i++)
      {
        if (hashset.Contains(i)) count++;
        else break;
      }
      res = Math.Max(res, count);
    }
    return res;
    }
}
