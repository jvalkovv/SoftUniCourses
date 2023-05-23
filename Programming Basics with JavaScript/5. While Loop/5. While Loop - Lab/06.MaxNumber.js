function maxNumber(params) {
  let cmd = params.shift();
  let max = Number.MIN_SAFE_INTEGER;

  while (String(cmd) !== "Stop") {
    let currNumber = Number(cmd);
    if (currNumber > max) {
      max = currNumber;
    }
    cmd = params.shift();
  }
  console.log(max);
}
maxNumber(["-1", "-2", "Stop"]);
