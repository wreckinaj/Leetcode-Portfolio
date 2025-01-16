#include <unordered_set>

class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {
        std::unordered_set<int> numSet;
        for(int i = 0; i < nums.size(); i++){
            if (numSet.contains(nums[i])){
                return true;
            }
            else{
                numSet.insert(nums[i]);
            }
        }
        return false;
    }
};