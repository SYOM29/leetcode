// O(V)
// O(1)
var maxDepth = function (root) {
  if (root == null) return 0;

  var left = maxDepth(root.left);
  var right = maxDepth(root.right);

  return left > right ? left + 1 : right + 1;
};
