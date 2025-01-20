class Solution:
    def longestCommonPrefix(self, strs: List[str]) -> str:
        if not strs:
            return ""
        new = ""
        strs = sorted(strs)
        first, last = strs[0], strs[-1]
        for i in range(len(first)):
            if i < len(last) and first[i] == last[i]:
                new += first[i]
            else:
                break
        return new