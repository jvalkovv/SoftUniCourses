function paint(input) {
  let bagPrice = 0.4;
  let nylon = 1.5;
  let paint = 14.5;
  let paintThinner = 5;

  let neededNylon = Number(input[0]) + 2;
  let neededPaintLiters = Number(input[1]) + Number(input[1]) * 0.1;
  let neededPaintThinner = Number(input[2]);
  let neededHour = Number(input[3]);

  let nylonSum = nylon * neededNylon;
  let paintSum = paint * neededPaintLiters;
  let paintThinnerSum = paintThinner * neededPaintThinner;

  let materialSum = nylonSum + paintSum + paintThinnerSum+0.40;
  let workmanPricePerHour = materialSum * 0.3;

  let workmanPriceForAllHours = neededHour*workmanPricePerHour;
  let allCost = materialSum+workmanPriceForAllHours;

  console.log(allCost);
}

paint(["10 ", "11 ", "4 ", "8 "]);
