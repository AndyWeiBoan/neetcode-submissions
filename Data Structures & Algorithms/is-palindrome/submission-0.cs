public class Solution 
{
    public bool IsPalindrome(string s) 
      {
    var right = s.Length - 1;
    var left = 0;
    while (left < right)
    {
      if (isValid(s[left]) == false)
      {
        left++;
        continue;
      }

      while (left < right && 
          false == isValid(s[right])) right--;

      if (s[left] != s[right]
          && (s[left] | 0x20) != (s[right]|0x20))
      {
        return false;
      }
      else 
      {
        left++;
        right--;
      }
    }
    return true;
  }

  public bool isValid(char c)
  {
    return (uint)((c | 0x20) - 'a') < 26 || (uint)(c - '0') < 10;
  }

}
