class Solution {
public:
    vector<int> topKFrequent(vector<int>& nums, int k) {
        std::unordered_map<int, int> count;
        std::vector<std::vector<int> > freq(nums.size() + 1);
        for(int n : nums){
            count[n] = 1 + count[n];
        }
        for(auto& it : count){
            freq[it.second].push_back(it.first);
        }
        std::vector<int> res;
        for(int i = freq.size() - 1; i > 0; i--){
            for(int num : freq[i]){
                res.push_back(num);
                if(res.size() == k){
                    return res;
                }
            }
        }
        return {};
    }
};