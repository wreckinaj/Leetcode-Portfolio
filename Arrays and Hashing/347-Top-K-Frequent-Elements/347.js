/**
 * @param {number[]} nums
 * @param {number} k
 * @return {number[]}
 */
var topKFrequent = function(nums, k) {
    const count = {};
    const freq = Array.from({length: nums.length + 1}, () => []);
    for(const n of nums){
        count[n] = 1 + (count[n] || 0);
    }
    for(const c in count){
        freq[count[c]].push(parseInt(c));
    }
    res = [];
    for(let i = freq.length - 1; i > 0; i--){
        for(const n of freq[i]){
            res.push(n);
            if(res.length == k){
                return res;
            }
        }
    }
};