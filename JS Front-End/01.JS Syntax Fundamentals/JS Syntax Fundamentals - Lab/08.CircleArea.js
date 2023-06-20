function solve(params) {
  let typeOfInput = typeof params;
  if (typeOfInput === "number") {
    let a = Number(params);
    let radius = Math.pow(a, 2) * Math.PI;
    console.log(radius.toFixed(2));
  } else {
    console.log(
      `We can not calculate the circle area, because we receive a ${typeOfInput}.`
    );
  }
}
solve(5);
solve("name");
