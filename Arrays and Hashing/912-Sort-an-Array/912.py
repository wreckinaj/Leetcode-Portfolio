class Solution:
    
    def merge(self, nums: List[int], left: int, mid: int, right: int):
        len1 = mid - left + 1
        len2 = right - mid
        L = [0] * len1
        R = [0] * len2
        for i in range(len1):
            L[i] = nums[left + i]
        for i in range(len2):
            R[i] = nums[mid + 1 + i]
        i = 0
        j = 0
        k = left
        while i < len1 and j < len2:
            if L[i] <= R[j]:
                nums[k] = L[i]
                i += 1
            else:
                nums[k] = R[j]
                j += 1
            k += 1
        while i < len1:
            nums[k] = L[i]
            i += 1
            k += 1
        while j < len2:
            nums[k] = R[j]
            j += 1
            k += 1

    def mergeSort(self, nums: List[int], left: int, right: int):
        if left < right:
            mid = (left + right) // 2
            self.mergeSort(nums, left, mid)
            self.mergeSort(nums, mid + 1, right)
            self.merge(nums, left, mid, right)
    
    def sortArray(self, nums: List[int]) -> List[int]:
        left = 0
        right = len(nums) - 1
        self.mergeSort(nums, left, right)
        return nums