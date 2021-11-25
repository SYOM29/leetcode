// Time: O(n^2)
// Space: O(n)
var countBits = function (n) {
  if (n == 0) return [0];

  var bits = new Array(n + 1);
  bits[0] = 0;
  bits[1] = 1;

  for (let i = 2; i <= n; i++) {
    bits[i] = findOnes(i);
  }

  return bits;
};

var findOnes = function (n) {
  if (n <= 2) return 1;

  var ones = 0;

  while (n > 0) {
    if (n % 2 == 1) ones = ones + 1;
    n = Math.floor(n / 2);
  }

  return ones;
};
