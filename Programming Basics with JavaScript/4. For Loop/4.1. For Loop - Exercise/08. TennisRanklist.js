function tenisRanklist(params) {
  let tournamentCount = Number(params.shift());
  let initialPoint = Number(params.shift());
  let tournamenPoint = 0;
  let wins = 0;
  for (let index = 1; index <= tournamentCount; index++) {
    let currPossition = String(params.shift());

    if (currPossition === "W") {
      tournamenPoint += 2000;
      wins++;
    } else if (currPossition === "F") {
      tournamenPoint += 1200;
    } else if (currPossition === "SF") {
      tournamenPoint += 720;
    }
  }

  initialPoint += tournamenPoint;
  console.log(`Final points: ${initialPoint}`);
  let avgPoint = tournamenPoint / tournamentCount;
  console.log(`Average points: ${Math.floor(avgPoint)}`);
  let percent = (wins / tournamentCount) * 100;
  console.log(`${percent.toFixed(2)}%`);
}
tenisRanklist(["4", "750", "SF", "W", "SF", "W"]);
