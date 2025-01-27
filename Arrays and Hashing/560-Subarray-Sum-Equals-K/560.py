class Solution:
    def subarraySum(self, nums: List[int], k: int) -> int:
        count = total = 0
        sumMap = {0:1}
        for num in nums:
            total += num
            if (total - k) in sumMap:
                count += sumMap[total - k]
            sumMap[total] = 1 + sumMap.get(total,0)
        return count