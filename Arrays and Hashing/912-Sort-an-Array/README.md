Given an array of integers nums, sort the array in ascending order and return it.

You must solve the problem without using any built-in functions in O(nlog(n)) time complexity and with the smallest space complexity possible.

 

Example 1:

Input: nums = [5,2,3,1]
Output: [1,2,3,5]
Explanation: After sorting the array, the positions of some numbers are not changed (for example, 2 and 3), while the positions of other numbers are changed (for example, 1 and 5).
Example 2:

Input: nums = [5,1,1,2,0,0]
Output: [0,0,1,1,2,5]
Explanation: Note that the values of nums are not necessairly unique.
 

Constraints:

1 <= nums.length <= 5 * 104
-5 * 104 <= nums[i] <= 5 * 104

Topics: Array, Divide and Conquer, Sorting, Heap, Merge Sort, Bucket Sort, Radix Sort, Counting Sort

Explanation: There are many ways to sort our way in O(n log n) times. For this problem, I used the merge sort algorithm. For those unfamiliar, it uses a divide and conquer method to divide the array in half repeatedly until single elements are in separate arrays. The singleton arrays are then combined to form arrays of double length until the sorted array is obtained. The two arrays being compared will already be sorted when merging them, so we just compare the arrays at specified indices until we need to switch to the other array in terms of taking the smallest element first.