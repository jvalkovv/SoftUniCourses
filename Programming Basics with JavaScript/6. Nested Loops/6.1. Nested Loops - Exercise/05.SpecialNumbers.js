function specialNumber(params) {
  let number = Number(params.shift());
  let consoleLine = "";
  for (let i = 1111; i <= 9999; i++) {
    let currNumber = "" + i;
    let counter = 0;
    for (let n = 0; n < currNumber.length; n++) {
      let currentDigit = Number(currNumber.charAt(n));
      if (number % currentDigit === 0) {
        counter++;
      }
      if (counter === currNumber.length) {
        consoleLine += `${currNumber} `;
        break;
      }
    }
  }
  console.log(consoleLine);
}
specialNumber(["3"]);
