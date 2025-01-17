public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string> > res = new Dictionary<string, IList<string> >();
        foreach(string s in strs){
            int[] count = new int[26];
            foreach(char c in s){
                count[c - 'a']++;
            }
            string key = string.Join(",", count);
            if(!res.ContainsKey(key)){
                res[key] = new List<string>();
            }
            res[key].Add(s);
        }
        return res.Values.ToList();
    }
}