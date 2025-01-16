class Solution {
public:
    bool isAnagram(string s, string t) {
        if(s.size() != t.size()){
            return false;
        }
        std::unordered_map<char, int> s_map;
        for(int i = 0; i < s.size(); i++){
            if(s_map.contains(s[i])){
                s_map[s[i]]++;
            }
            else{
                s_map[s[i]] = 1;
            }
        }
        for(int i = 0; i < t.size(); i++){
            if(s_map.contains(t[i])){
                if(s_map[t[i]] == 0){
                    return false;
                }
                else{
                    s_map[t[i]]--;
                }
            }
            else{
                return false;
            }
        }
        return true;
    }
};