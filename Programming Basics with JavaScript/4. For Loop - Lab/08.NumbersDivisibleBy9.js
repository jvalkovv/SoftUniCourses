function divisible(params) {
  let firstNumber = Number(params[0]);
  let lastNumber = Number(params[1]);

  let numbers;
  let sum = 0;

  for (let index = firstNumber; index <= lastNumber; index++) {
    let currNumber = index;

    if (currNumber % 9 == 0) {
      sum += currNumber;
      numbers += currNumber;
    }
  }
 console.log(`The sum: ${sum}`);

 for (let index = firstNumber; index <= lastNumber; index++) {
    let currNumber = index;

    if (currNumber % 9 == 0) {
     console.log(currNumber);
    }
  }
}
divisible(["100", "200"]);