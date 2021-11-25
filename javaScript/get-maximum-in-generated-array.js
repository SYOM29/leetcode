// Time: O(n)
// Space: O(n)
var getMaximumGenerated = function (n) {
  if (n <= 1) return n;

  var maxArr = new Array(n + 1);
  maxArr[0] = 0;
  maxArr[1] = 1;

  var max = 1;

  for (let i = 2; i <= n; i++) {
    var curr = 0;
    var div = Math.floor(i / 2);

    if (i % 2 == 0) {
      curr = maxArr[div];
      maxArr[i] = curr;
    } else {
      curr = maxArr[div] + maxArr[div + 1];
      maxArr[i] = curr;
    }

    if (curr > max) max = curr;
  }

  return max;
};
