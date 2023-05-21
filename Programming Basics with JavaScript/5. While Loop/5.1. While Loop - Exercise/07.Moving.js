function move(params) {
  let freeWidth = Number(params.shift());
  let freeLength = Number(params.shift());
  let freeHeight = Number(params.shift());
  let boxSize = 0;
  let freeSpace = freeHeight * freeLength * freeWidth;
  while (true) {
    let cmd = params.shift();
    let countBox = Number(cmd);
    let done = String(cmd);
    if (!isNaN(countBox)) {
      boxSize += countBox;
    }
    if (done === "Done") {
        freeSpace-=boxSize;
      console.log(`${freeSpace} Cubic meters left.`);
      return;
    } else if (freeSpace <= boxSize) {
      freeSpace -= boxSize;
      console.log(
        `No more free space! You need ${Math.abs(freeSpace)} Cubic meters more.`
      );
      return;
    }
  }
}
move(["10", 
"10",
"2",
"20",
"20",
"20",
"20",
"122"])
;
