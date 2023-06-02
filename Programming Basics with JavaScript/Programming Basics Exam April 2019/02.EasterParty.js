function easterParty(params) {
  let guestCount = Number(params.shift());
  let pricePerOneGuest = Number(params.shift());
  let budgetOfDesi = Number(params.shift());

  if (guestCount >= 10 && guestCount <= 15) {
    pricePerOneGuest *= 0.85;
  } else if (guestCount >= 15 && guestCount <= 20) {
    pricePerOneGuest *= 0.8;
  } else if (guestCount > 20) {
    pricePerOneGuest *= 0.75;
  }
  let cakePrice = budgetOfDesi * 0.1;
  let priceForAllGuest = guestCount * pricePerOneGuest;
  let neededMoney = priceForAllGuest+cakePrice;
  let leftBudget = Math.abs(budgetOfDesi - neededMoney);
  if (budgetOfDesi >= neededMoney) {
    console.log(`It is party time! ${leftBudget.toFixed(2)} leva left.`);
  } else {
    console.log(`No party! ${leftBudget.toFixed(2)} leva needed.`);
  }
}
easterParty(["18", "30", "450"]);
