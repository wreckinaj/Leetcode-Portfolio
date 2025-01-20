class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        if(!strs.size()){
            return "";
        }
        string prefix = "";
        sort(strs.begin(), strs.end());
        string first = strs[0];
        string last = strs.back();
        for(int i = 0; i < first.size(); i++){
            if(i < last.size() && first[i] == last[i]){
                prefix += first[i]; 
            }
            else{
                break;
            }
        }
        return prefix;
    }
};