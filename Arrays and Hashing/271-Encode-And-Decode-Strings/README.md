DISCLAIMER: This is a Leetcode Premium problem. Note that I do not own a Premium subscription, so it is unlikely many more Premium problems will appear in this portfolio. This problem was requisitioned from Neetcode, so the description on here may not match the description on the actual Leetcode website.

Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

Please implement encode and decode

Example 1:

Input: ["neet","code","love","you"]

Output:["neet","code","love","you"]
Example 2:

Input: ["we","say",":","yes"]

Output: ["we","say",":","yes"]
Constraints:

0 <= strs.length < 100
0 <= strs[i].length < 200
strs[i] contains only UTF-8 characters.

Explanation: This program requires two function definitions, where one "undoes" the action of the other. To encode the strings in the array, I started each one with the number of characters in the string, then separated the count with a # character, though it is possible to use a different character. The strings are combined into a single string one-by-one.

For the decode function, the goal is to get back the array passed in the encode function. The idea is to use two pointer variables. The first purpose is to use them to collect the number of characters in one substring. One variable is at the first digit of the string length, and the other is at the # symbol. Once the string length is collected, the first variable moves to the first character of the string, and the second moves as many units as the collected length. The cycle continues until the full string is spliced correctly.