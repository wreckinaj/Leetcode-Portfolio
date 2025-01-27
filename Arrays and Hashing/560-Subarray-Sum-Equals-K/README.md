Given an array of integers nums and an integer k, return the total number of subarrays whose sum equals to k.

A subarray is a contiguous non-empty sequence of elements within an array.

 

Example 1:

Input: nums = [1,1,1], k = 2
Output: 2
Example 2:

Input: nums = [1,2,3], k = 3
Output: 2
 

Constraints:

1 <= nums.length <= 2 * 104
-1000 <= nums[i] <= 1000
-107 <= k <= 107

Topics: Array, Hash Table, Prefix Sum

Explanation: This problem can be solved using prefix sums. We will want to keep a map to store the prefix sums at each index. We initialize it with a sum of 0 assigned a value of 1 to account for singleton subarrays. We then iterate through the array, adding to our total variable as we go. Each time we add to our total, we check to see if the difference between this variable and k is in our map. If so, we add to our answer the number of times this key appears in the map. Either way, we either initialize the key and assign it the value of 1, or we just add 1 to the previous value.