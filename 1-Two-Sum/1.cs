public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> numMap = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(numMap.ContainsKey(diff)){
                return [i, numMap[diff]];
            }
            numMap[nums[i]] = i;
        }
        return [];
    }
}