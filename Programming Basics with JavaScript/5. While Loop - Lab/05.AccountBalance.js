function balance(params) {
  let totalsum = 0;

  let cmd = params.shift();

  while (cmd !== "NoMoreMoney") {
    if (Number(cmd) < 0) {
      console.log("Invalid operation!");
      break;
    } else if (Number(cmd) > 0) {
      console.log(`Increase: ${Number(cmd).toFixed(2)}`);
      totalsum += Number(cmd);
    }
    cmd = params.shift();
  }
  console.log(`Total: ${totalsum.toFixed(2)}`);
}
balance(["120", "45.55", "-150"]);
