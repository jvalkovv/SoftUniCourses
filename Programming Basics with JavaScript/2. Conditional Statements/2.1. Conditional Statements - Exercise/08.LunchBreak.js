function lunchBreak(cmd) {
  let movieName = String(cmd[0]);
  let movieDuration = Number(cmd[1]);
  let lunchBreakDuration = Number(cmd[2]);

  let timeForLunch = lunchBreakDuration / 8;
  let timeForRelax = lunchBreakDuration / 4;
  let timeForMovie = lunchBreakDuration - timeForLunch - timeForRelax;

  let leftTime = Math.ceil(Math.abs(timeForMovie - movieDuration));

  if (timeForMovie >= movieDuration) {
    console.log(
      `You have enough time to watch ${movieName} and left with ${leftTime} minutes free time.`
    );
  } else {
    console.log(`You don't have enough time to watch ${movieName}, you need ${leftTime} more minutes.`);
  }
}
lunchBreak(["Teen Wolf",
"48",
"60"])

;
