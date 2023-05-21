function arraySums(params) {
  let input = params.shift();
  let primeNumber = 0;
  let nonPrimeNumber = 0;
  while (input !== "stop") {
    let numbers = Number(input);
    if (numbers < 0) {
      console.log("Number is negative.");
      input = params.shift();
      continue;
    }
    let isPrime = true;

    if (numbers === 1) {
      isPrime = false;
      input = params.shift();
      continue;
    } else {
      for (let i = numbers; i >= 2; i--) {
        if (numbers % i == 0 && i != numbers) {
          isPrime = false;
          break;
        }
      }
    }
    if (isPrime === true) {
      primeNumber += numbers;
    } else if (isPrime === false) {
      nonPrimeNumber += numbers;
    }
    input = params.shift();
  }
  console.log(`Sum of all prime numbers is: ${primeNumber}`);
  console.log(`Sum of all non prime numbers is: ${nonPrimeNumber}`);
}
arraySums(["30", "1", "83", "33", "-1", "20", "stop"]);
