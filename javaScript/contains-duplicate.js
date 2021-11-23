// Time: O(n)
// Space: O(n)
var containsDuplicate = function (nums) {
  var seen = new Set();
  for (let i = 0; i < nums.length; i++) {
    if (seen.has(nums[i])) {
      return true;
    }

    seen.add(nums[i]);
  }

  return false;
};
