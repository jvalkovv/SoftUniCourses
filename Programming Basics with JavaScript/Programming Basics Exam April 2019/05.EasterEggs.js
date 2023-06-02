function eggsPainting(params) {
  let paintedEggs = Number(params.shift());
  let color = String(params.shift());

  let redCount = 0;
  let orangeCount = 0;
  let blueCount = 0;
  let greenCount = 0;
  let maxColorCounter = Number.MIN_SAFE_INTEGER;
  let maxColorEggsColor = "";
  for (let index = 1; index <= paintedEggs; index++) {
    if (color === "red") {
      redCount++;
      if (redCount >= maxColorCounter) {
        maxColorCounter = redCount;
        maxColorEggsColor = "red";
      }
    } else if (color === "orange") {
      orangeCount++;
      if (orangeCount >= maxColorCounter) {
        maxColorCounter = orangeCount;
        maxColorEggsColor = "orange";
      }
    } else if (color === "blue") {
      blueCount++;
      if (blueCount >= maxColorCounter) {
        maxColorCounter = blueCount;
        maxColorEggsColor = "blue";
      }
    } else if (color === "green") {
      greenCount++;
      if (greenCount >= maxColorCounter) {
        maxColorCounter = greenCount;
        maxColorEggsColor = "green";
      }
    }
 
    color = String(params.shift());
  }
  console.log(`Red eggs: ${redCount}`);
  console.log(`Orange eggs: ${orangeCount}`);
  console.log(`Blue eggs: ${blueCount}`);
  console.log(`Green eggs: ${greenCount}`);
  console.log(`Max eggs: ${maxColorCounter} -> ${maxColorEggsColor}`);
}
eggsPainting(["7",
"orange",
"blue",
"green",
"green",
"blue",
"red",
"green"])
 ;