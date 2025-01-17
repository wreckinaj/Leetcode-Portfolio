Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

 

Example 1:

Input: nums = [1,2,3,1]

Output: true

Explanation:

The element 1 occurs at the indices 0 and 3.

Example 2:

Input: nums = [1,2,3,4]

Output: false

Explanation:

All elements are distinct.

Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]

Output: true

 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109

Topics: Array, Hash Table, Sorting

Explanation: An obvious solution is brute force, thus using a nested loop to determine if values at two distinct indices in the array are equal. However, because of the nested for loop, we would have an O(n^2) time complexity. We could also potentially sort the function, then loop through the array once to see if we get an instance where two consecutive values in the array are equal. However, this would require an O(n log n) time complexity by using the built-in sort function for the specific language.

The final solution in this code uses a set. We loop through the array once, and determine if the observed value is in our set. If yes, then we have found a duplicate and return true. If no, then we append the observed value into our set. If we loop through the entire array, then no duplicate is found, and we return false.