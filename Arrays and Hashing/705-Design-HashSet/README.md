NOTE: If you wish for me to provide a solution using linked lists for chaining, leave a comment and I will provide a new solution in each language and an explanation for that specific approach.

Design a HashSet without using any built-in hash table libraries.

Implement MyHashSet class:

void add(key) Inserts the value key into the HashSet.
bool contains(key) Returns whether the value key exists in the HashSet or not.
void remove(key) Removes the value key in the HashSet. If key does not exist in the HashSet, do nothing.
 

Example 1:

Input
["MyHashSet", "add", "add", "contains", "contains", "add", "contains", "remove", "contains"]
[[], [1], [2], [1], [3], [2], [2], [2], [2]]
Output
[null, null, null, true, false, null, true, null, false]

Explanation
MyHashSet myHashSet = new MyHashSet();
myHashSet.add(1);      // set = [1]
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(1); // return True
myHashSet.contains(3); // return False, (not found)
myHashSet.add(2);      // set = [1, 2]
myHashSet.contains(2); // return True
myHashSet.remove(2);   // set = [1]
myHashSet.contains(2); // return False, (already removed)
 

Constraints:

0 <= key <= 106
At most 104 calls will be made to add, remove, and contains.

Topics: Array, Hash Table, Linked List, Design, Hash Function

Explanation: The hash set was built using arrays for chaining, where each index in the array stores another array of keys for that index. Because of people's familiarity with arrays, this makes the solution much easier to implement, and it also allows for faster access to data since we can easily access a specific element with built-in functions depending on what language you are using. However, it is likely that you may have too much memory allocated into your array, and even if you do have to resize your array, it costs a lot more time, especially for large data sets.