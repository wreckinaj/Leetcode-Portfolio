/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let numMap = new Map();
    for(let i = 0; i < nums.length; i++){
        let diff = target - nums[i];
        if(numMap.has(diff)){
            return [i, numMap.get(diff)];
        }
        numMap.set(nums[i], i);
    }
};