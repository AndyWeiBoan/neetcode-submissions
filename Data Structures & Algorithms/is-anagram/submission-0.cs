public class Solution {
    public bool IsAnagram(string s, string t) {
        var fir = s.ToArray();
        Array.Sort(fir);
        var sec = t.ToArray();
        Array.Sort(sec);
        return Enumerable.SequenceEqual(fir, sec);
    }
}
