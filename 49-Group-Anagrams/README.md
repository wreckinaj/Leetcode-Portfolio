Given an array of strings strs, group the 
anagrams
 together. You can return the answer in any order.

 

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]

Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Explanation:

There is no string in strs that can be rearranged to form "bat".
The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
Example 2:

Input: strs = [""]

Output: [[""]]

Example 3:

Input: strs = ["a"]

Output: [["a"]]

 

Constraints:

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.

Topics: Array, Hash Table, String, Sorting

Explanation: one way to think of anagrams is two words with the same count of each character used. The 2D array that needs to be returned is an array with arrays of words with those shared characters. The final solution uses a hash map to store the counts of the 26 letters as keys and arrays the associated words in the input array as values. The program loops through each word, and in each iteration, an array of size 26 is created to count the number of times a character appears in the array. Then we loop through the observed string and count up each character that appears in the string. The letter count data is appended to the map as necessary, and the associated word is appended to the value array. The results from the map are converted to a 2D array as determined by the programming language. 

Note that while this solution runs faster than sorting each word, it takes up extra memory due to the need for storing a count array.