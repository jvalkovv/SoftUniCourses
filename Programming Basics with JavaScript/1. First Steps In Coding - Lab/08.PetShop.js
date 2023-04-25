function cost(input) {
  let dogPackagePrice = 2.5;
  let catPackagePrice = 4;
  let dogPackage = input[0];
  let catPackage = input[1];

  let dogSum = dogPackage*dogPackagePrice;
  let catSum = catPackage*catPackagePrice;
  let result = dogSum + catSum;

  console.log(`${result} lv.`)
}
cost(["5","4"]);