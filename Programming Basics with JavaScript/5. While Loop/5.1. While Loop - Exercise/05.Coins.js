function coin(params) {
  let instead = Number(Math.round(params.shift() * 100));
  let count = 0;
  while (instead !== 0) {
    if (instead >= 200) {
      instead -= 200;
    } else if (instead >= 100) {
      instead -= 100;
    } else if (instead >= 50) {
      instead -= 50;
    } else if (instead >= 20) {
      instead -= 20;
    } else if (instead >= 10) {
      instead -= 10;
    } else if (instead >= 5) {
      instead -= 5;
    } else if (instead >= 2) {
      instead -= 2;
    } else if (instead >= 1) {
      instead -= 1;
    }
    count++;
  }
  console.log(count);
}
coin(["0.56"]);
