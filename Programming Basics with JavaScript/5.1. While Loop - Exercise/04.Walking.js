function walks(params) {
  let dailySteps = 10000;
  let totalSteps = 0;
  let upDiff = 0;
  let downDiff = 0;
  for (let index = 0; index < params.length; index++) {
    let cmd = params[index];
    let currStep = Number(cmd);
    let text = String(cmd);
    if (!isNaN(currStep)) {
      totalSteps += currStep;
    }
    let additionalSteps = 0;
    if (text === "Going home") {
      let currIndex = params.indexOf(cmd);
      currIndex += 1;
      additionalSteps = Number(params[currIndex]);
      totalSteps += additionalSteps;
      index = params[currIndex];
    }
    downDiff = Math.abs(totalSteps - dailySteps);
  }
  if (totalSteps >= dailySteps) {
    console.log("Goal reached! Good job!");
    console.log(`${downDiff} steps over the goal!`);
  } else {
    console.log(`${downDiff} more steps to reach goal.`);
  }
}
walks(["1500",
"3000",
"250",
"1548",
"2000",
"Going home",
"2000"])
;
