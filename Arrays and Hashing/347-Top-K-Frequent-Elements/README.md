Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]
Example 2:

Input: nums = [1], k = 1
Output: [1]
 

Constraints:

1 <= nums.length <= 105
-104 <= nums[i] <= 104
k is in the range [1, the number of unique elements in the array].
It is guaranteed that the answer is unique.
 

Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.

Topics: Array, Hash Table, Divide and Conquer, Sorting, Heap, Bucket Sort, Counting, Quick Select

Explanation: There are multiple ways to solve this problem, such as sorting the array and implementing a heap. However, the solution here uses the bucket sort algorithm. It starts by declaring a hash map to store the count of each number in the array, as well as a 2D array that serves as the "bucket" for collecting the values, with the indices equal to the count of a number. The algorithm proceeds by traversing the array and collecting the counts, transferring the data from the map to the bucket, and pushing the elements into a results array until k elements are pushed.