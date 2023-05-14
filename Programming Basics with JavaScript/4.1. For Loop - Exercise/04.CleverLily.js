function lily(params) {
  let lilyAge = Number(params[0]);
  let laundryPrice = Number(params[1]);
  let priceForToy = Number(params[2]);

  let money = 0;
  let takenMoney = 0;
  let toyCount = 0;

  let evenBd = 0;
  for (let index = 1; index <= lilyAge; index++) {
    if (index % 2 === 0) {
      evenBd++;
      money += evenBd * 10;
      takenMoney++;
    } else {
      toyCount++;
    }
  }

  let moneyFromToys = toyCount * priceForToy;
  let allMoney = money + moneyFromToys - takenMoney;

  if (allMoney >= laundryPrice) {
    console.log(`Yes! ${(allMoney - laundryPrice).toFixed(2)}`);
  } else {
    console.log(`No! ${Math.abs(allMoney - laundryPrice).toFixed(2)}`);
  }
}
lily(["21",
"1570.98",
"3"])
;
