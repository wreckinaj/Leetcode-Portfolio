/**
 * @param {string[]} strs
 * @return {string[][]}
 */
var groupAnagrams = function(strs) {
    const res = {};
    for(let i = 0; i < strs.length; i++){
        const count = new Array(26).fill(0);
        for(let j = 0; j < strs[i].length; j++){
            count[strs[i][j].charCodeAt(0) - 'a'.charCodeAt(0)] += 1;
        }
        const key = count.join(',');
        if(!res[key]){
            res[key] = [];
        }
        res[key].push(strs[i]);
    }
    return Object.values(res);
};