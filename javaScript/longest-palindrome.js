// Time: O(n)
// Space: O(n)
var longestPalindrome = function (s) {
  var obj = {};
  var pal = 0;

  for (let i = 0; i < s.length; i++) {
    obj[s[i]] = (obj[s[i]] || 0) + 1;

    if (obj[s[i]] % 2 == 0) pal += 2;
  }

  return s.length > pal ? pal + 1 : pal;
};
