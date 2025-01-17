public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, int> s_map = new Dictionary<char,int>();
        foreach(var letter in s){
            if(s_map.ContainsKey(letter)){
                s_map[letter]++;
            }
            else{
                s_map[letter] = 1;
            }
        }
        foreach(var letter in t){
            if(s_map.ContainsKey(letter)){
                if(s_map[letter] == 0){
                    return false;
                }
                else{
                    s_map[letter]--;
                }
            }
            else{
                return false;
            }
        }
        return true;
    }
}