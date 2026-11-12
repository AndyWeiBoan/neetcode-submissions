public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        var dict = new Dictionary<string, List<string>>();

        foreach (var s in strs)
        {
        var map = new int[26];

        for (int i = 0; i < s.Length; i++) map[s[i] - 'a'] += 1;

        var key = string.Join("#", map);
        if (dict.ContainsKey(key)) dict[key].Add(s);
        else dict.Add(key, new List<string> { s});
        }
        return dict.Values.ToList();
    }
}
