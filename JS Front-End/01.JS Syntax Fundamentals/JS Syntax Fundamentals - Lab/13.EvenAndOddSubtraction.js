function solve(params) {
  let evenSum = 0;
  let oddSum = 0;
  for (let index = 0; index < params.length; index++) {
    if (params[index] % 2 === 0) {
      evenSum += Number(params[index]);
    } else {
      oddSum += Number(params[index]);
    }
  }
  console.log(evenSum - oddSum);
}
solve([3, 5, 7, 9]);
