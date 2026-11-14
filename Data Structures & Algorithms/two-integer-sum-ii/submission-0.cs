public class Solution 
{
    public int[] TwoSum(int[] numbers, int target) 
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (right > left)
        {
            var val = numbers[left] + numbers[right];

            if (val == target) return [left + 1, right + 1];
            else if (val > target) right--;
            else left++;
        }
        return [];
    }
}
