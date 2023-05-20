function traveling(params) {
  let destination = params.shift();
  let neededMoney = params.shift();
  while (destination !== "End") {
    let currentSavedMoney = 0;
    while (currentSavedMoney < neededMoney) {
      let savedMoney = Number(params.shift());
      currentSavedMoney += savedMoney;
    }
    console.log(`Going to ${destination}!`);
    destination = params.shift();
    neededMoney = params.shift();
  }
}
traveling([
  "Greece",
  "10000",
  "200",
  "200",
  "300",
  "100",
  "150",
  "240",
  "Spain",
  "1200",
  "300",
  "500",
  "193",
  "423",
  "End",
]);
