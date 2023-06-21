function addAndSubtract(firstNumber, secondNumber, thirdNumber) {
  const sum = (firstNumber, secondNumber) => {
    return firstNumber + secondNumber;
  };
  const subtract = (result, thirdNumber) => {
    return result - thirdNumber;
  };
  let sumResult = sum(firstNumber, secondNumber);
  let finalResult = subtract(sumResult, thirdNumber);
  console.log(finalResult);
}
addAndSubtract(23, 6, 10);
