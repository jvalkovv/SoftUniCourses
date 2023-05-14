function sumOfNumbers(params) {
  let arrayDigits = String(params[0]);
  let sum = 0;
  for (let index = 0; index < arrayDigits.length; index++) {
    let currDigit = arrayDigits[index];
    sum += Number(currDigit);
  }

  console.log(`The sum of the digits is:${sum}`);
}
sumOfNumbers(["1234"]);
