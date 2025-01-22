class MyHashSet {
public:
    vector<vector<int>> set_array;
    MyHashSet() {
        set_array.resize(10000);
    }
    
    void add(int key) {
        int idx = key % 10000;
        for(int x : set_array[idx]){
            if(x == key){
                return;
            }
        }
        set_array[idx].push_back(key);
    }
    
    void remove(int key) {
        int idx = key % 10000;
        for(int i = 0; i < set_array[idx].size(); i++){
            if(set_array[idx][i] == key){
                set_array[idx].erase(set_array[idx].begin() + i);
                return;
            }
        }
    }
    
    bool contains(int key) {
        int idx = key % 10000;
        for(int x : set_array[idx]){
            if(x == key){
                return true;
            }
        }
        return false;
    }
};

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet* obj = new MyHashSet();
 * obj->add(key);
 * obj->remove(key);
 * bool param_3 = obj->contains(key);
 */