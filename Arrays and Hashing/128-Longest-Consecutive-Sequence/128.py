class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        numSet = set(nums)
        ans = 0
        for num in numSet:
            if num - 1 not in numSet:
                length = 1
                while (num + length) in numSet:
                    length += 1
                ans = max(ans, length)
        return ans