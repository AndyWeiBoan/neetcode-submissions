public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        var res = new int[nums.Length];

        var left = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = 1;
            res[i] *= left;
            left *= nums[i];
        }

        var right = 1;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            res[i] *= right;
            right *= nums[i];
        }
        return res;
    }
}
