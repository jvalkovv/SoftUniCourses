function fishing(params) {
  let groupBudget = Number(params[0]);
  let season = String(params[1]);
  let countFishMan = Number(params[2]);

  let disscount = 0;
  let rentForSeason = 0;

  if (countFishMan <= 6) {
    disscount = 0.9;
  } else if (countFishMan >= 7 && countFishMan <= 11) {
    disscount = 0.85;
  } else if (countFishMan >= 12) {
    disscount = 0.75;
  }

  if (season === "Spring") {
    rentForSeason = 3000;
  } else if (season === "Summer") {
    rentForSeason = 4200;
  } else if (season === "Autumn") {
    rentForSeason = 4200;
  } else if (season === "Winter") {
    rentForSeason = 2600;
  }

  let neededMoney = rentForSeason * disscount;
  if (countFishMan % 2 === 0 && season !== "Autumn") {
    neededMoney *= 0.95;
  }
  let leftMoney = Math.abs(groupBudget - neededMoney).toFixed(2);

  if (groupBudget >= neededMoney) {
    console.log(`Yes! You have ${leftMoney} leva left.`);
  } else if (groupBudget < neededMoney) {
    console.log(`Not enough money! You need ${leftMoney} leva.`);
  }
}
