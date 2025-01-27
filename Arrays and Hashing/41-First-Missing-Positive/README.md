Given an unsorted integer array nums. Return the smallest positive integer that is not present in nums.

You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.

 

Example 1:

Input: nums = [1,2,0]
Output: 3
Explanation: The numbers in the range [1,2] are all in the array.
Example 2:

Input: nums = [3,4,-1,1]
Output: 2
Explanation: 1 is in the array but 2 is missing.
Example 3:

Input: nums = [7,8,9,11,12]
Output: 1
Explanation: The smallest positive integer 1 is missing.
 

Constraints:

1 <= nums.length <= 105
-231 <= nums[i] <= 231 - 1

Topics: Array, Hash Table

Explanation: The answer must lie within the range of [1, n + 1], where n is the size of the array. Therefore, we can make an attempt to sort the array without any knowledge of what the elements are except the ones we examine at the instant. We make one pass through the array, and use it to try to position each number at index i - 1. Then we make another pass to find the first instance where the number at index i is i + 1, which would be our answer. If we complete through the second pass, then the answer is n + 1, as the array will have all the positive integers from 1 to n.