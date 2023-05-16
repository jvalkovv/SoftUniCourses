function minNumber(params) {
  let cmd = params.shift();
  let min = Number.MAX_SAFE_INTEGER;

  while (String(cmd) !== "Stop") {
    let currNumber = Number(cmd);

    if (currNumber < min) {
      min = currNumber;
    }

    cmd = params.shift();
  }
  console.log(min);
}
minNumber(["-1", "-2", "Stop"]);
