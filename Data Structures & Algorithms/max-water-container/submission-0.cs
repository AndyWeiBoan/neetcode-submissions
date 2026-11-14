public class Solution {
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var res = 0;
        while (right > left)
        {
            var h = Math.Min(height[left], height[right]);
            var l = right - left;
            res = Math.Max(res, h * l);
            if (height[left] > height[right]) right--;
            else left++;
        }
        return res;
    }
}
