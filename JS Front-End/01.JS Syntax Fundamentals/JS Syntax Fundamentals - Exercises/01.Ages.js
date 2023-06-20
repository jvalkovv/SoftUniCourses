function solve(ages) {
  let result = "";
  if (ages >= 0 && ages <= 2) {
    result = "baby";
  } else if (ages >= 3 && ages <= 13) {
    result = "child";
  } else if (ages >= 14 && ages <= 19) {
    result = "teenager";
  } else if (ages >= 20 && ages <= 65) {
    result = "adult";
  } else if (ages > 65) {
    result = "elder";
  } else {
    result = "out of bounds";
  }

  console.log(result);
}
solve(20);
