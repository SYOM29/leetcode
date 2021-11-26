// Time: O(n)
// Space: O(1)
var balancedStringSplit = function (s) {
  var count = 0;
  var splits = 0;

  for (let i = 0; i < s.length; i++) {
    count += s[i] === "L" ? 1 : -1;
    if (count == 0) splits++;
  }

  return splits;
};
