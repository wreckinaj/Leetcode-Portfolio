Write a function that reverses a string. The input string is given as an array of characters s.

You must do this by modifying the input array in-place with O(1) extra memory.

 

Example 1:

Input: s = ["h","e","l","l","o"]
Output: ["o","l","l","e","h"]
Example 2:

Input: s = ["H","a","n","n","a","h"]
Output: ["h","a","n","n","a","H"]
 

Constraints:

1 <= s.length <= 105
s[i] is a printable ascii character.

Topics: Two Pointers, String

Explanation: This problem requires the two pointer method, where we declare the left pointer at index 0, and the right pointer at index n - 1 (n being the length of the string). Until we reach the middle element or have the left and right pointers pass, we swap the characters at the left and right pointers, followed by incrementing the left pointer and decrementing the right pointer.