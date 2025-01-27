class Solution:
    def majorityElement(self, nums: List[int]) -> List[int]:
        element_counter = Counter(nums)
        majority_elements = []
        minimum = len(nums) // 3
        for element, count in element_counter.items():
            if count > minimum:
                majority_elements.append(element)
        return majority_elements