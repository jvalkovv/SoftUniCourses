function bracelet(params) {
  let leftDayToBd = 5;
  let moneyPerDay = Number(params.shift());
  let earnMoneyPerDay = Number(params.shift());
  let allExpense = Number(params.shift());

  let giftPrice = Number(params.shift());

  let totalMoney = moneyPerDay * leftDayToBd;
  let totalEarn = earnMoneyPerDay * leftDayToBd;
  let leftMoney = totalEarn + totalMoney - allExpense;

  if (leftMoney >= giftPrice) {
    console.log(
      `Profit: ${leftMoney.toFixed(2)} BGN, the gift has been purchased.`
    );
  } else {
    leftMoney -= giftPrice;
    console.log(`Insufficient money: ${Math.abs(leftMoney).toFixed(2)} BGN.`);
  }
}
bracelet(["2.10", "17.50", "20.20", "148.50"]);
