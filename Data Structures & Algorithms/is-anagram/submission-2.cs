public class Solution {
    public bool IsAnagram(string s, string t) {
        var s_arr = new int[26];
        foreach (var c in s) s_arr[c - 97] +=1;

        var t_arr = new int[26];
        foreach (var c in t) t_arr[c - 97]+=1;

        for(int i=0; i < 26; i++)
        {
            if (s_arr[i] != t_arr[i]) return false;
        }
        return true;
    }
}
