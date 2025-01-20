public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if(strs.Length == 0){
            return "";
        }
        Array.Sort(strs);
        string result = "";
        string first = strs[0];
        string last = strs[strs.Length - 1];
        for(int i = 0; i < first.Length; i++){
            if(i < last.Length && first[i] == last[i]){
                result += first[i]; 
            }
            else{
                break;
            }
        }
        return result;
    }
}