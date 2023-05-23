function numbers(params) {
  let inputNumber = Number(params.shift());
  let sum = 0;
  while (true) {
    let number = Number(params.shift());
    sum += number;
    if (sum >= inputNumber) {
      console.log(sum);
      break;
    }
  }
}
numbers(["20",
"1",
"2",
"3",
"4",
"5",
"6"]);