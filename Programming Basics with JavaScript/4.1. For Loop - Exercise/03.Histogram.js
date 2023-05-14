function histogram(params) {
  let numberToInput = Number(params[0]);

  let p1 = 0;
  let p2 = 0;
  let p3 = 0;
  let p4 = 0;
  let p5 = 0;
  for (let index = 1; index <= numberToInput; index++) {
    let currNumber = Number(params[index]);
    if (currNumber < 200) {
      p1++;
    } else if (currNumber >= 200 && currNumber <= 399) {
      p2++;
    } else if (currNumber >= 400 && currNumber <= 599) {
      p3++;
    } else if (currNumber >= 600 && currNumber <= 799) {
      p4++;
    } else if (currNumber >= 800) {
      p5++;
    }
  }
  let p1Percent = p1/numberToInput*100;
  let p2Percent = p2/numberToInput*100;
  let p3Percent = p3/numberToInput*100;
  let p4Percent = p4/numberToInput*100;
  let p5Percent = p5/numberToInput*100;
  
  console.log(`${p1Percent.toFixed(2)}%`);
  console.log(`${p2Percent.toFixed(2)}%`);
  console.log(`${p3Percent.toFixed(2)}%`);
  console.log(`${p4Percent.toFixed(2)}%`);
  console.log(`${p5Percent.toFixed(2)}%`);
}
histogram(["7",
"800",
"801",
"250",
"199",
"399",
"599",
"799"]);
