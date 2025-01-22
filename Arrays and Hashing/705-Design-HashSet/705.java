class MyHashSet {

    List<Integer>[] set_array;

    public MyHashSet() {
        set_array = new ArrayList[10000];
        for(int i = 0; i < 10000; i++){
            set_array[i] = new ArrayList<>();
        }
    }
    
    public void add(int key) {
        int idx = key % 10000;
        if(!set_array[idx].contains(key)){
            set_array[idx].add(key);
        }
    }
    
    public void remove(int key) {
        int idx = key % 10000;
        set_array[idx].remove(Integer.valueOf(key));
    }
    
    public boolean contains(int key) {
        int idx = key % 10000;
        return set_array[idx].contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.add(key);
 * obj.remove(key);
 * boolean param_3 = obj.contains(key);
 */