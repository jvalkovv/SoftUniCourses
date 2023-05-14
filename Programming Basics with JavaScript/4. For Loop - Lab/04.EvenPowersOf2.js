function evenPowerOf2(params) {
  let num = Number(params[0]);

  for (let index = 0; index <= num; index++) {

    if (index % 2 == 0) {
      console.log(Math.pow(2, index));
    }
  }
}
evenPowerOf2("3");
