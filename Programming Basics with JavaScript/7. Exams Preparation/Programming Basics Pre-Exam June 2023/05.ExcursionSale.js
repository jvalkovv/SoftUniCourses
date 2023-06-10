function excursion(params) {
  let seaCountExcursion = Number(params.shift());
  let mountainCountExcursion = Number(params.shift());

  let seaPrice = 680;
  let mountainPrice = 499;
  let finalPrice = 0;
  let input = String(params.shift());
  while (input !== "Stop") {
    if (seaCountExcursion <= 0 && mountainCountExcursion <= 0) {
      console.log(`Good job! Everything is sold.`);
      console.log(`Profit: ${finalPrice} leva.`);
      return;
    }
    if (input === "sea") {
      if (seaCountExcursion > 0) {
        seaCountExcursion -= 1;
        finalPrice += seaPrice;
      }
    } else if (input === "mountain") {
      if (mountainCountExcursion > 0) {
        mountainCountExcursion -= 1;
        finalPrice += mountainPrice;
      }
    }

    input = String(params.shift());
  }
  console.log(`Profit: ${finalPrice} leva.`);
}
excursion(["2", "2", "sea", "mountain", "sea", "sea", "mountain"]);
