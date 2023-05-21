function equalSums(params) {
  let firstNumber = Number(params.shift());
  let secondNumber = Number(params.shift());

  let result = "";

  for (let i = firstNumber; i <= secondNumber; i++) {
    let currNumber = "" + i;
    let evenSum = 0;
    let oddSum = 0;
    for (let n = 0; n < currNumber.length; n++) {
      let currentDigit = Number(currNumber.charAt(n));
      if (n % 2 == 0) {
        evenSum += currentDigit;
      } else {
        oddSum += currentDigit;
      }
    }
    if (evenSum === oddSum) {
      result += `${i} `;
    }
  }
  console.log(result);
}
equalSums(["100000", "100050"]);
