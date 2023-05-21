function numbersWithStep3(params) {

  let receiveNumber = Number(params[0]);

  for (let index = 1; index <= receiveNumber; index += 3) {
    console.log(index);
  }
}
numbersWithStep3(["10"]);
