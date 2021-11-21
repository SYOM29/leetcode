var addTwoNumbers = function (l1, l2) {
  if (l1 == null && l2 == null) return null;

  var answer = new ListNode(0, null);
  var current = answer;
  var carry = 0;

  while (l1 != null || l2 != null || carry != 0) {
    var temp = carry;
    carry = 0;
    if (l1 != null) {
      temp = temp + l1.val;
      l1 = l1.next;
    }
    if (l2 != null) {
      temp = temp + l2.val;
      l2 = l2.next;
    }

    if (temp > 9) {
      temp = temp % 10;
      carry = carry + 1;
    }

    current.next = new ListNode(temp, null);
    current = current.next;
  }

  return answer.next;
};
