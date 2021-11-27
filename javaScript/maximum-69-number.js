var maximum69Number = function (num) {
  var temp = num.toString();
  var max = "";
  var isConverted = false;

  for (let i = 0; i < temp.length; i++) {
    if (temp[i] === "6" && !isConverted) {
      max += "9";
      isConverted = true;
    } else {
      max += temp[i];
    }
  }

  return new Number(max);
};
