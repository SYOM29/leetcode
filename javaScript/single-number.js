// Time: O(n)
// Space: O(1)
var singleNumber = function (nums) {
  var temp = 0;
  for (let num of nums) {
    temp = temp ^ num;
  }

  return temp;
};
