// Time: O(n)
// Space: O(n)
var tribonacci = function (n) {
  if (n == 0) return 0;
  if (n <= 2) return 1;

  var trib = new Array(n + 1);
  trib[0] = 0;
  trib[1] = 1;
  trib[2] = 1;

  for (let i = 3; i <= n; i++) {
    trib[i] = trib[i - 1] + trib[i - 2] + trib[i - 3];
  }

  return trib[n];
};
