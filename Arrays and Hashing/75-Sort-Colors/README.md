Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.

We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.

You must solve this problem without using the library's sort function.

 

Example 1:

Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]
Example 2:

Input: nums = [2,0,1]
Output: [0,1,2]
 

Constraints:

n == nums.length
1 <= n <= 300
nums[i] is either 0, 1, or 2.
 

Follow up: Could you come up with a one-pass algorithm using only constant extra space?

Topics: Array, Two Pointers, Sorting

Explanation: Since we just have the tertiary digits to work with, we just need to think about the 0's being on the left side, the 2's on the right side, and the 1's in the middle. We make three pointers. One points to the beginning of the search area, another starts pointing at the beginning of the search area and marks the index of interest, and the last points to the end of the search area.

There are three cases for this middle pointer being used. If it runs into a 0, it needs to get moved to the left, so the values at the left and middle pointers get swapped. Since the left pointer (and everything before it) will be 0 at that point, it needs to get incremented. The middle pointer will also need to be incremented since the current index will be correct.

If it runs into a 1, there is nothing to do, so the middle pointer is incremented.

If it runs into a 2, it needs to get moved to the right, so the values at the middle and right pointers get swapped. Since the right pointer (and everything after it) will be 2 at that point, it need to be decremented. The middle pointer remains neutral, as there is the potential a 0 needs to get moved from the right to the left, or a 2 gets moved to the middle and needs to be moved back again.

When the middle pointer surpasses the right pointer, the search is complete, and the array is sorted.