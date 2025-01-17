/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function(s, t) {
    if(s.length != t.length){
        return false;
    }
    let s_map = new Map();
    for(let i = 0; i < s.length; i++){
        if(s_map.has(s[i])){
            s_map.set(s[i], s_map.get(s[i]) + 1);
        }
        else{
            s_map.set(s[i], 1);
        }
    }
    for(let i = 0; i < t.length; i++){
        if(s_map.has(t[i])){
            if(s_map.get(t[i]) == 0){
                return false;
            }
            else{
                s_map.set(t[i], s_map.get(t[i]) - 1);
            }
        }
        else{
            return false;
        }
    }
    return true;
};