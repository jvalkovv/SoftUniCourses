function eggsBattle(params) {
  let fpEggsCount = Number(params.shift());
  let spEggsCount = Number(params.shift());

  let cmd = String(params.shift());

  while (true) {
    if (cmd === "End") {
      console.log(`Player one has ${fpEggsCount} eggs left.`);
      console.log(`Player two has ${spEggsCount} eggs left.`);
      break;
    }
    if (fpEggsCount <= 0) {
      console.log(
        `Player one is out of eggs. Player two has ${spEggsCount} eggs left.`
      );
      break;
    } else if (spEggsCount <= 0) {
      console.log(
        `Player two is out of eggs. Player one has ${fpEggsCount} eggs left.`
      );
      break;
    }
    if (cmd == "one") {
      spEggsCount -= 1;
    } else if (cmd == "two") {
      fpEggsCount -= 1;
    }
    cmd = String(params.shift());
  }
}
eggsBattle(["6", "3", "one", "two", "two", "one", "one"]);
