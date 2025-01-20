Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

 

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"
Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.
 

Constraints:

1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters if it is non-empty.

Topics: String, Trie

Explanation: By default, if the array is empty, the result will be an empty string. Otherwise, we proceed as follows. We sort the array to begin. Then because of the sorting, the first and last strings will have the biggest difference in characters. We use a pointer in a loop, and append letters until we reach a difference, or when we run out of letters in the first word in the case where the first word is simply the prefix to the last word. We terminate and return the result.