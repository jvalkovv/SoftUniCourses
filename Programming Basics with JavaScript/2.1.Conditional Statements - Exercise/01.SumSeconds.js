function secondSum(input) {
    let minutes = 0;

    let firstTime = Number(input[0]);
    let secondTime = Number(input[1]);
    let thirtTime = Number(input[2]);

    let secondsSum = firstTime + secondTime + thirtTime;

    while (secondsSum >= 60) {
        secondsSum -= 60;
        minutes++
    }
    let second = secondsSum;

    if (second < 10) {
        console.log(`${minutes}:0${second}`)
    }
    else{
        console.log(`${minutes}:${second}`)
    }
}
