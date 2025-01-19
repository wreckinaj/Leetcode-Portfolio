Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].

The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in O(n) time and without using the division operation.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 

Constraints:

2 <= nums.length <= 105
-30 <= nums[i] <= 30
The input is generated such that answer[i] is guaranteed to fit in a 32-bit integer.
 

Follow up: Can you solve the problem in O(1) extra space complexity? (The output array does not count as extra space for space complexity analysis.)

Topics: Array, Prefix Sum

Explanation: The obvious solution is to collect the product of all the elements, then divide this by each element to get the desired array. However, we are not allowed to do that here. Therefore, using prefix and suffix sums are helpful with this solution. The multiplication starts at the second element, and then we use a postfix variable to work backwards. Note it is possible to only use one array for an optimal solution.