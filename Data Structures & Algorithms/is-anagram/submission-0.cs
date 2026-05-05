public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if(s.Length != t.Length) 
            return false;

        var anagram = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(anagram.ContainsKey(s[i]))
                anagram[s[i]]++;
            else
                anagram[s[i]] = 1;

            if(anagram.ContainsKey(t[i]))
                anagram[t[i]]--;
            else
                anagram[t[i]] = -1;
        }

        foreach(var c in anagram)
            if(c.Value != 0) return false;
        
        return true;
    }
}
