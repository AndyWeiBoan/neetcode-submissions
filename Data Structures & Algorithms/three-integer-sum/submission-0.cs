public class Solution 
{
    public List<List<int>> ThreeSum(int[] nums) 
  {
    Array.Sort(nums);
    var res = new List<List<int>>();

    for (int i = 0; i < nums.Length; i++)
    {
      if (i > 0 && nums[i] == nums[i - 1]) continue;

      var j = i + 1;
      var k = nums.Length - 1;

      while (k > j)
      {
        var val = nums[i] + nums[j] + nums[k];

        if (val == 0)
        {
          res.Add(new List<int> { nums[i], nums[j], nums[k] });
          j++;
          k--;
          while (k > j && nums[j] == nums[j - 1]) j++;
          while (k > j && nums[k] == nums[k + 1]) k--;
        }
        else if (val < 0) j++;
        else k--;
      }
    }
    return res;
  }

}
