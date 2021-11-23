// Time: O(n)
// Space: O(1)
// Algorithm: Kadane's algorithm
var maxSubArray = function (nums) {
  if (nums == null || nums.length == 0) return -Infinity;
  if (nums.length == 1) return nums[0];

  var curr = 0;
  var max = -Infinity;

  for (let i = 0; i < nums.length; i++) {
    curr = curr + nums[i];
    if (curr > max) max = curr;
    if (curr < 0) curr = 0;
  }

  return max;
};
