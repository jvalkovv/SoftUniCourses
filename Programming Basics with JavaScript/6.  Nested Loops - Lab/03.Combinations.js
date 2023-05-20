function combinations(params) {
  let input = Number(params.shift());
  let countValidCombinations = 0;
  for (let i = 0; i <= input; i++) {
    for (let j = 0; j <= input; j++) {
      for (let k = 0; k <= input; k++) {
        let sum = i + j + k;
        if (sum === input) {
          countValidCombinations++;
        }
      }
    }
  }
  console.log(countValidCombinations);
}
combinations(["25"]);
