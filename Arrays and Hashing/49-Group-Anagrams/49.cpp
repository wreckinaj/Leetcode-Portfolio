class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        std::unordered_map <string, vector<string> > res;
        for(int i = 0; i < strs.size(); i++){
            vector<int> count(26,0);
            for(int j = 0; j < strs[i].size(); j++){
                count[strs[i][j] - 'a']++;
            }
            string key = to_string(count[0]);
            for(int j = 1; j < 26; j++){
                key += ',' + to_string(count[j]);
            }
            res[key].push_back(strs[i]);
        }
        vector<vector<string> > ans;
        for(auto& pair : res){
            ans.push_back(pair.second);
        }
        return ans;
    }
};