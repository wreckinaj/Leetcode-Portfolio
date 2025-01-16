class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(t) != len(s):
            return False
        s_map = {}
        for letter in s:
            if letter in s_map:
                s_map[letter] += 1
            else:
                s_map[letter] = 1
        for letter in t:
            if letter in s_map:
                if s_map[letter] == 0:
                    return False
                else:
                    s_map[letter] -= 1
            else:
                return False
        return True