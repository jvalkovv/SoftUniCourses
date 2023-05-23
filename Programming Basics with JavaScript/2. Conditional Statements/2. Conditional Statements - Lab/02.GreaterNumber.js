function number(input) {
  let numberOne = Number(input[0]);
  let numberTwo = Number(input[1]);

  if (numberOne > numberTwo) {
    console.log(numberOne);
  } else if (numberOne < numberTwo) {
    console.log(numberTwo);
  } else if (numberOne === numberTwo) {
    console.log(numberOne);
  }
}
number(["-5 ", "3 "]);
