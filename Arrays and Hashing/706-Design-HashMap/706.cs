public class Node {
    public int key, value;
    public Node next;

    public Node(int key, int value, Node next) {
        this.key = key;
        this.value = value;
        this.next = next;
    }
}

public class MyHashMap {
    int size = 19997;
    int mult = 12582917;
    Node[] data;

    public MyHashMap() {
        this.data = new Node[size];
    }

    private int hash(int key) {
        return (int)((long)key * mult % size);
    }
    
    public void Put(int key, int value) {
        Remove(key);  // Ensure no duplicates in the map before inserting
        int h = hash(key);
        Node node = new Node(key, value, data[h]);
        data[h] = node;
    }
    
    public int Get(int key) {
        int h = hash(key);
        Node node = data[h];
        while (node != null) {
            if (node.key == key) {
                return node.value;
            }
            node = node.next;
        }
        return -1;
    }
    
    public void Remove(int key) {
        int h = hash(key);
        Node node = data[h];
        if (node == null) return;

        // If the node to be removed is the first one in the list
        if (node.key == key) {
            data[h] = node.next;
            return;
        }

        // Otherwise, traverse the list to find the node
        while (node.next != null) {
            if (node.next.key == key) {
                node.next = node.next.next;
                return;
            }
            node = node.next;
        }
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */