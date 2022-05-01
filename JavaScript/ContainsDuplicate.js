console.log(containsDuplicate([1,6,3,4,2,7]));
console.log(containsDuplicate([1,2,3,1]));
console.log(containsDuplicate([1,2,3,4]));
console.log(containsDuplicate([1,6,3,4,2,7,2,4]));
console.log(containsDuplicate([1,1,1,3,3,4,3,2,4,2]));

function containsDuplicate(nums) {
    let temp = [];
    for(let i = 0; i < nums.length; i++){
        if(temp.includes(nums[i])){
            return true;
        } else {
            temp.unshift(nums[i]);
        }
    }
    return false;
};