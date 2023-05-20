function sums(params) {
  let begin = Number(params.shift());
  let ends = Number(params.shift());
  let magicNumber = Number(params.shift());

  let countCombination = 0;
  for (let i = begin; i <= ends; i++) {
    for (let j = begin; j <= ends; j++) {
      let sum = i + j;
      countCombination++;
      if (sum === magicNumber) {
        console.log(
          `Combination N:${countCombination} (${i} + ${j} = ${magicNumber})`
        );
        return;
      }
    }
  }
  console.log(
    `${countCombination} combinations - neither equals ${magicNumber}`
  );
}
sums(["88", "888", "2000"]);
