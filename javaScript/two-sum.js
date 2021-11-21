var twoSum = function (nums, target) {
  if (nums == null || nums.length == 1) return [];

  var compMap = {};

  for (let i = 0; i < nums.length; i++) {
    var comp = target - nums[i];
    if (compMap[comp] >= 0) {
      return [compMap[comp], i];
    }
    compMap[nums[i]] = i;
  }

  return [];
};
