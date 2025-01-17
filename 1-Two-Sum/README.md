Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

You can return the answer in any order.

 

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:

2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n^2) time complexity?

Topics: Array, Hash Table

Explanation: An obvious solution is a nested loop and check the array n times. However, this has an O(n^2) time complexity. You could also potentially sort the array, and then use two pointers. However, multiple steps are still taken here.

The final solution in this code utilizes a hash map, which collects index values for each value found. We iterate through the array, and determine if the remaining value after taking the difference between the target and observed values exists in the map. If so, we found our answer, and return the indices. If not, we append the observed value into the map, and assign its value the index value respective to the array.