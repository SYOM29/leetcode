//Time: O(n)
//Space: O(1)
var reverseString = function (s) {
  var i = 0;
  var j = s.length - 1;

  while (i < j) {
    var temp = s[i];
    s[i] = s[j];
    s[j] = temp;
    i++;
    j--;
  }
};
