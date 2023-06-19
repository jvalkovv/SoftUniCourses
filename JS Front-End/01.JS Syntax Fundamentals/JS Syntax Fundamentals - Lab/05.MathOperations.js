function solve(n1, n2, operator) {
  let result;
  switch (operator) {
    case "+":
      result = n1 + n2;
      break;
    case "-":
      result = n1 - n2;
      break;
    case "*":
      result = n1 * n2;
      break;
    case "/":
      result = n1 / n2;
      break;
    case "%":
      result = n1 % n2;
      break;
    case "**":
      result = n1 ** n2;
      break;
    default:
      break;
  }
  console.log(result);
}
solve(5, 6, "+");
