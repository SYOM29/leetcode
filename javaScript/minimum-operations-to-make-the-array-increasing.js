// Time: O(n)
// Space: O(1)
var minOperations = function (nums) {
  var ops = 0;

  for (let i = 1; i < nums.length; i++) {
    if (nums[i - 1] >= nums[i]) {
      ops += nums[i - 1] - nums[i] + 1;
      nums[i] = nums[i - 1] + 1;
    }
  }

  return ops;
};
