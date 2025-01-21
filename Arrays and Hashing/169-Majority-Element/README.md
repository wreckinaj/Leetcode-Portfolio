Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

 

Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2
 

Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109
 

Follow-up: Could you solve the problem in linear time and in O(1) space?

Topics: Array, Hash Table, Divide and Conquer, Sorting, Counting

Explanation: This problem was interesting. My original idea was to use a hash map on the array, then look through the map to find the element with the highest frequency count. While it worked, it obviously did not match up with the follow-up question due to the extra space used. Therefore, I examined an algorithm that would continuously stored a count for a candidate of the answer, as well as the candidate itself. The count variable would both be incremented and decremented. Each time the count went to 0, it suggested that the number in question was not a majority element due to lack of presence, and we switch to a new number. The count incremented each time we find our candidate number, and decremented when we do not.