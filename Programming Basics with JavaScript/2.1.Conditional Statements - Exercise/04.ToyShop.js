function shop(cmd) {

    let puzzlePrice = 2.60;
    let speakingDollPrice = 3;
    let teddyBearPrice = 4.10;
    let minionPrice = 8.20;
    let truckPrice = 2;

    let priceOfVacation = Number(cmd.shift());
    let puzzlesCount = Number(cmd.shift());
    let talkingDollsCount = Number(cmd.shift());
    let teddyBearsCount = Number(cmd.shift());
    let minionsCount = Number(cmd.shift());
    let trucksCount = Number(cmd.shift());

    let allOrderToys = puzzlesCount + talkingDollsCount + teddyBearsCount + minionsCount + trucksCount;

    let earnMOney = (puzzlePrice * puzzlesCount) + (talkingDollsCount * speakingDollPrice) + (teddyBearPrice * teddyBearsCount) + (minionPrice * minionsCount) + (trucksCount * truckPrice);

    if (allOrderToys >= 50) {
        earnMOney *= 0.75;
    }
    earnMOney *= 0.90;
    if (earnMOney >= priceOfVacation) {

        console.log(`Yes! ${(earnMOney - priceOfVacation).toFixed(2)} lv left.`);
    }
    else if (earnMOney < priceOfVacation) {
        console.log(`Not enough money! ${Math.abs(earnMOney - priceOfVacation).toFixed(2)} lv needed.`);
    }

}