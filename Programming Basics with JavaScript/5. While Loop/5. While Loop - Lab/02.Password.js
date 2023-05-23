function password(params) {
  let user = String(params.shift());
  let password = String(params.shift());

  let cmd = String(params.shift());

  while (true) {
    if (cmd === password) {
      console.log(`Welcome ${user}!`);
      break;
    }
    cmd = String(params.shift());
  }
}
password(["Nakov", "1234", "Pass", "1324", "1234"]);
