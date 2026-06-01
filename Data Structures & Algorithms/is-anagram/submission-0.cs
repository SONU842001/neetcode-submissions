public class Solution {
    public bool IsAnagram(string s, string t) {
        int len1 = s.Length;
        int len2 = t.Length;
        if(len1 != len2)
        {
            return false;
        }
        var hashArray = new int[26];
        foreach(char c in s)
        {
            hashArray[c - 'a']++;
        }

        foreach(char c in t)
        {
            hashArray[c-'a']--;
        }

        for(int i =0;i< hashArray.Length;i++)
        {
            if(hashArray[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}
