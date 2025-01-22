
var MyHashSet = function() {
    this.setArray = new Array(10000);
    for(let i = 0; i < 10000; i++){
        this.setArray[i] = [];
    }
};

/** 
 * @param {number} key
 * @return {void}
 */
MyHashSet.prototype.add = function(key) {
    const idx = key % 10000;
    if (!this.setArray[idx].includes(key)) {
        this.setArray[idx].push(key);
    }
};

/** 
 * @param {number} key
 * @return {void}
 */
MyHashSet.prototype.remove = function(key) {
    const idx = key % 10000;
    const index = this.setArray[idx].indexOf(key);
    if (index !== -1) {
        this.setArray[idx].splice(index, 1);
    }
};

/** 
 * @param {number} key
 * @return {boolean}
 */
MyHashSet.prototype.contains = function(key) {
    const idx = key % 10000;
    return this.setArray[idx].includes(key);
};

/** 
 * Your MyHashSet object will be instantiated and called as such:
 * var obj = new MyHashSet()
 * obj.add(key)
 * obj.remove(key)
 * var param_3 = obj.contains(key)
 */