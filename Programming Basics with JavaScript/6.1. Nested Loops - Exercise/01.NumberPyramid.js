function pyramid(params) {
  let n = Number(params.shift());
  let counter = 1;
  let isBigger = false;
  let printLine = "";
  for (let rows = 1; rows <= n; rows++) {
    for (let cols = 1; cols <= rows; cols++) {
      if (counter > n) {
        isBigger = true;
        break;
      }
      printLine += counter + " ";
      counter++;
    }
    console.log(printLine);
    printLine = "";
    if (isBigger) {
      break;
    }
  }
}
pyramid(["7"]);
