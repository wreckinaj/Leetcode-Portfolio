class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        std::vector<int> res(nums.size(), 1);
        for(int i = 1; i < nums.size(); i++){
            res[i] = res[i - 1] * nums[i - 1];
        }
        int postfix = 1;
        for(int i = nums.size() - 1; i > -1; i--){
            res[i] *= postfix;
            postfix *= nums[i];
        }
        return res;
    }
};