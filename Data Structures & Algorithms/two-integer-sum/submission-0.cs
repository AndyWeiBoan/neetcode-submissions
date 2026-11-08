public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var res = new List<int>();
        var dict = new Dictionary<int, int>();

        for (int i=0; i < nums.Length; i++)
        {
            var value = target - nums[i];
            if (dict.ContainsKey(nums[i]))
            {
                res.Add(dict[nums[i]]);
                res.Add(i);
            }
            else
            {
                dict.Add(value, i);
            }
        }
        return res.ToArray();
    }
}
