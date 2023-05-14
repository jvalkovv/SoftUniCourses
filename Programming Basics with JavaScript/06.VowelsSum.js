function vowels(params) {
  let input = String(params[0]);
  let sum = 0;
  for (let index = 0; index < input.length; index++) {
    let currLetter = input[index];
    if (currLetter === "a") {
      sum += 1;
    } else if (currLetter === "e") {
      sum += 2;
    } else if (currLetter === "i") {
      sum += 3;
    } else if (currLetter === "o") {
      sum += 4;
    } else if (currLetter === "u") {
      sum += 5;
    }
  }

  console.log(sum);
}
vowels(["bamboo"]);