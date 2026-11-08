public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hash = new HashSet<int>(nums.Length);

        for (int i =0; i < nums.Length; i++)
        {
            if (!hash.Add(nums[i])) return true;
        }
        return false;
    }
}