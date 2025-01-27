Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.

 

Example 1:

Input: nums = [3,2,3]
Output: [3]
Example 2:

Input: nums = [1]
Output: [1]
Example 3:

Input: nums = [1,2]
Output: [1,2]
 

Constraints:

1 <= nums.length <= 5 * 104
-109 <= nums[i] <= 109
 

Follow up: Could you solve the problem in linear time and in O(1) space?

Topics: Array, Hash Table, Sorting, Counting

Explanation: I was not able to come up with a solution with O(1) space complexity, so I am posting this solution instead. The program uses a hash map to count up elements (I used the Counter collection in Python), and then we iterate through the map to find the elements that have a frequency above n // 3. One thing I will note for future work is that there can be at most two candidates for our answer.