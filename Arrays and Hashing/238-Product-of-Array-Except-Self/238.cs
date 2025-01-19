public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] res = new int[nums.Length];
        Array.Fill(res, 1);
        for(int i = 1; i < nums.Length; i++){
            res[i] = res[i - 1] * nums[i - 1];
        }
        int postfix = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            res[i] *= postfix;
            postfix *= nums[i];
        }
        return res;
    }
}