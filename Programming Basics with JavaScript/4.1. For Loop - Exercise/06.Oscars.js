function oscar(params) {
  let name = String(params.shift());
  let academyPoint = Number(params.shift());
  let judgeCount = Number(params.shift());
  let minPoint = 1250.5;
  for (let index = 0; index < judgeCount; index++) {
    let currJudge = String(params.shift());
    let currJudgePoint = Number(params.shift());
    let pointFromJudgeName = (currJudge.length * currJudgePoint) / 2;
    academyPoint += pointFromJudgeName;
    if (academyPoint >= minPoint) {
      console.log(
        `Congratulations, ${name} got a nominee for leading role with ${academyPoint.toFixed(1)}!`
      );
      return;
    }
  }
  if (academyPoint < minPoint) {
    let neededPoint = Math.abs(academyPoint - minPoint);
    console.log(`Sorry, ${name} you need ${neededPoint.toFixed(1)} more!`);
  }
}
oscar([
  "Sandra Bullock",
  "340",
  "5",
  "Robert De Niro",
  "50",
  "Julia Roberts",
  "40.5",
  "Daniel Day-Lewis",
  "39.4",
  "Nicolas Cage",
  "29.9",
  "Stoyanka Mutafova",
  "33",
]);
