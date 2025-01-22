public class MyHashSet {
    
    private List<int>[] setArray;

    public MyHashSet() {
        setArray = new List<int>[10000];
        for (int i = 0; i < 10000; i++) {
            setArray[i] = new List<int>();
        }
    }
    
    public void Add(int key) {
        int idx = key % 10000;
        if (!setArray[idx].Contains(key)) {
            setArray[idx].Add(key);
        }
    }
    
    public void Remove(int key) {
        int idx = key % 10000;
        setArray[idx].Remove(key);
    }
    
    public bool Contains(int key) {
        int idx = key % 10000;
        return setArray[idx].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */