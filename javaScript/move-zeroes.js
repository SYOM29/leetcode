// Time: O(n)
// Space: O(1)
var moveZeroes = function (nums) {
  var nonZeroCount = 0;

  for (let i = 0; i < nums.length; i++) {
    if (nums[i] !== 0) {
      nums[nonZeroCount] = nums[i];
      nums[i] = nonZeroCount === i ? nums[i] : 0;
      nonZeroCount = nonZeroCount + 1;
    }
  }
};
