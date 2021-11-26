// Time: O(n)
// Space: O(n)
var inorderTraversal = function (root) {
  if (root == null) return [];

  var left = inorderTraversal(root.left);
  left.push(root.val);
  var right = inorderTraversal(root.right);
  left = [...left, ...right];
  return left;
};

// Time: O(n)
// Space: O(n)
var inorderTraversal = function (root) {
  if (root == null) return [];

  var vals = [];
  var nodes = [];

  while (root != null || nodes.length > 0) {
    while (root != null) {
      nodes.push(root);
      root = root.left;
    }

    root = nodes.pop();
    if (root == null) break;
    vals.push(root.val);
    root = root.right;
  }

  return vals;
};
