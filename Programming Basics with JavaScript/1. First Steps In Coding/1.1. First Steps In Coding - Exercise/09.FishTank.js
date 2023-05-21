function tank(input) {
  let lengthCen = Number(input[0]);
  let widthCen = Number(input[1]);
  let heightCen = Number(input[2]);
  let percent = 1 - Number(input[3]) / 100;

  let volume = lengthCen * widthCen * heightCen;
  let volumeLiters = volume * 0.001;

  volumeLiters *= percent;

  console.log(volumeLiters);
}

tank(["85 ", "75 ", "47 ", "17 "]);
