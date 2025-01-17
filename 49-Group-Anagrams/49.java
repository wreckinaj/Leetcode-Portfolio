class Solution {
    public List<List<String>> groupAnagrams(String[] strs) {
        HashMap<String, List<String> > res = new HashMap<>();
        for(int i = 0; i < strs.length; i++){
            int[] count = new int[26];
            for(int j = 0; j < strs[i].length(); j++){
                count[strs[i].charAt(j) - 'a']++;
            }
            String key = Arrays.toString(count);
            res.putIfAbsent(key, new ArrayList<>());
            res.get(key).add(strs[i]);
        }
        return new ArrayList<>(res.values());
    }
}