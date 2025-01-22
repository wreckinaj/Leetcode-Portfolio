class MyHashSet:

    def __init__(self):
        self.set_array = [[]] * 10000

    def add(self, key: int) -> None:
        idx = key % 10000
        if not key in self.set_array[idx]:
            self.set_array[idx].append(key)

    def remove(self, key: int) -> None:
        idx = key % 10000
        if key in self.set_array[idx]:
            self.set_array[idx].remove(key)

    def contains(self, key: int) -> bool:
        idx = key % 10000
        if key in self.set_array[idx]:
            return True
        else:
            return False


# Your MyHashSet object will be instantiated and called as such:
# obj = MyHashSet()
# obj.add(key)
# obj.remove(key)
# param_3 = obj.contains(key)