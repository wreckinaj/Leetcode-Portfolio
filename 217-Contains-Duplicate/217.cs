public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numSet = new HashSet<int>();
        foreach(var num in nums){
            if(numSet.Contains(num)){
                return true;
            }
            else{
                numSet.Add(num);
            }
        }
        return false;
    }
}