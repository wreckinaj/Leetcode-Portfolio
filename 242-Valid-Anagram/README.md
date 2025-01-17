Given two strings s and t, return true if t is an 
anagram
 of s, and false otherwise.

 

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

 

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
 

Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?

Topics: Hash Table, String, Sorting

Explanation: For the solution, a hash map or dictionary is used. The keys in the map would be the character found in string s, and the value would be the number of times would initially be the number of times that character appears in s. To start, note that s and t cannot be anagrams of each other if they are not the same length. This case is covered first to save on unnecessary memory. Then the program loops through s and collects the count of each character in s. Then the program loops through t. It first checks to see if the observed character is in our map. If not, then the two strings are not anagrams. Otherwise, the program then checks if we already have our count for that character at 0. If not, then there are too many instances of one character, and the two strings are not anagrams. Otherwise, we decrement the count of the character in the hash map. If we loop through the entire string t without running into trouble, the two strings are anagrams. Note it is not necessary to check if the map has any keys with nonzero values, as the program already checks for proper length and unequal counts of characters properly.