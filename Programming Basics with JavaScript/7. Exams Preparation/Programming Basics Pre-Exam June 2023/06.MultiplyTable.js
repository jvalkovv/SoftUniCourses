function multipleTable(params) {
  let n = String(params.shift());
  let fDigit = Number(n[2]);
  let sDigit = Number(n[1]);
  let tDigit = Number(n[0]);

  for (let i = 1; i <= fDigit; i++) {
    for (let j = 1; j <= sDigit; j++) {
      for (let k = 1; k <= tDigit; k++) {
        console.log(`${i} * ${j} * ${k} = ${i * j * k};`);
      }
    }
  }
}
multipleTable(["222"]);
