function vacantion(params) {
  let budgetForVacantion = Number(params[0]);
  let season = String(params[1]);

  let destination = "";
  let nights = "";
  let spendMoney = 0;

  if (budgetForVacantion <= 100) {
    if (season === "summer") {
      spendMoney = budgetForVacantion * 0.3;
      nights = "Camp";
    } else if (season === "winter") {
      spendMoney = budgetForVacantion * 0.7;
      nights = "Hotel";
    }
    destination = "Bulgaria";
  } else if (budgetForVacantion > 100 && budgetForVacantion <= 1000) {
    if (season === "summer") {
      spendMoney = budgetForVacantion * 0.4;
      nights = "Camp";
    } else if (season === "winter") {
      spendMoney = budgetForVacantion * 0.8;
      nights = "Hotel";
    }
    destination = "Balkans";
  } else if (budgetForVacantion > 1000) {
    spendMoney = budgetForVacantion * 0.9;
    destination = "Europe";
    nights = "Hotel";
  }

  console.log(`Somewhere in ${destination}`);
  console.log(`${nights} - ${spendMoney.toFixed(2)}`);
}
