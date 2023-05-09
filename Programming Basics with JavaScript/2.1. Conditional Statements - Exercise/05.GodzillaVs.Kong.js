function movie(input) {
    let movieBudget = Number(input[0]);
    let staticCount = Number(input[1]);
    let priceForClothPerStatic = Number(input[2]);

    let decorate = movieBudget * 0.10;

    if (staticCount > 150) {
        priceForClothPerStatic = priceForClothPerStatic - priceForClothPerStatic * 0.10;
    }

    let staticPrice = staticCount * priceForClothPerStatic;

    let neededSum = staticPrice + decorate;

    if (movieBudget >= neededSum) {
        let leftMoney = movieBudget - neededSum;
        console.log("Action!");
        console.log(`Wingard starts filming with ${(leftMoney).toFixed(2)} leva left.`)
    }
    else {
        let moneyNeed = Math.abs(movieBudget - neededSum);
        console.log("Not enough money!");
        console.log(`Wingard needs ${(moneyNeed).toFixed(2)} leva more.`)
    }
}