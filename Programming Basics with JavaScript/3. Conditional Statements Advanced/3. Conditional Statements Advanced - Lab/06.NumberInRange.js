function rangerChecker(cmd) {
  
let number = Number(cmd[0]);

  if (number >= (100*-1) && number <= 100 && number !== 0) {
    console.log("Yes");
  } else {
    console.log("No");
  }
}
