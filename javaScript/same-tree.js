// Time: O(n)
// Space: O(1)
var isSameTree = function (p, q) {
  if (p == null && q == null) return true;

  if ((p != null && q == null) || (p == null && q != null) || p.val != q.val) {
    return false;
  }

  var left = isSameTree(p.left, q.left);
  var right = isSameTree(p.right, q.right);

  if (!left || !right) return false;
  return true;
};
