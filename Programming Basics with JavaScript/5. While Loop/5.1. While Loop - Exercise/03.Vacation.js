function vacantion(params) {
  let neededMoney = Number(params.shift());
  let currMoney = Number(params.shift());
  let countDays = 0;
  let countSpendDays = 0;
  while (currMoney < neededMoney) {
    let cmd = String(params.shift());
    let money = Number(params.shift());
    countDays++;
    if (cmd === "spend") {
      currMoney -= money;
      if (currMoney < 0) {
        currMoney = 0;
      }
      countSpendDays++;
    } else if (cmd === "save") {
      currMoney += money;
      countSpendDays = 0;
    }
    if (countSpendDays === 5) {
      console.log("You can't save the money.");
      console.log(`${countDays}`);
      return;
    }
  }
  console.log(`You saved the money for ${countDays} days.`);
}
vacantion(["110",
"60",
"spend",
"10",
"spend",
"10",
"spend",
"10",
"spend",
"10",
"spend",
"10"])
;
