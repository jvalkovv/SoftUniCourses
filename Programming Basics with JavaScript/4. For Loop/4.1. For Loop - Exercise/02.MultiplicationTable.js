function table(params) {
  let number = Number(params[0]);

  for (let index = 1; index <= 10; index++) {
    console.log(`${index} * ${number} = ${index * number}`);
  }
}
table(["5"]);
