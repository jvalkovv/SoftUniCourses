function shop(input) {
  let graphicCard = Number(250);
  let budgetPeter = Number(input[0]);
  let graphicCardCount = Number(input[1]);
  let cpuCount = Number(input[2]);
  let ramCount = Number(input[3]);

  let sumForGraphicCards = graphicCard * graphicCardCount;
  let sumForSingleCpu = sumForGraphicCards * 0.35;
  let sumForSingleRam = sumForGraphicCards * 0.1;

  let sumForAllCpu = cpuCount*sumForSingleCpu;
  let sumForAllRams = ramCount*sumForSingleRam;

  let neededMoney = sumForGraphicCards+sumForAllCpu+sumForAllRams;
  if(graphicCardCount>cpuCount){
    neededMoney*=0.85;
  }
  let leftMoney = budgetPeter-neededMoney;
  
  if(budgetPeter>=neededMoney){
    console.log(`You have ${Math.abs(leftMoney).toFixed(2)} leva left!`)
  }
  else{
    console.log(`Not enough money! You need ${Math.abs(leftMoney).toFixed(2)} leva more!`);
  }
}

shop(["900",
"2",
"1",
"3"])
;
