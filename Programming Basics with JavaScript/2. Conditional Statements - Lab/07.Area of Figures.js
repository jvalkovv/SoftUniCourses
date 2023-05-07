function area(input) {
  let figures = String(input[0]);

  if (figures === "square") {
    let sizeSquare = Number(input[1]);
    console.log(`${(sizeSquare * sizeSquare).toFixed(3)}`);
  } else if (figures === "rectangle") {
    let sizeA = Number(input[1]);
    let sizeB = Number(input[2]);
    let result = sizeA * sizeB;
    console.log(`${result.toFixed(3)}`);
  } else if (figures === "circle") {
    let sizeCircle = Number(input[1]);

    let result = sizeCircle*sizeCircle*Math.PI;

    console.log(`${(result).toFixed(3)}`)
  } else if (figures === "triangle") {
    let sizeA = Number(input[1]);
    let sizeHeigh = Number(input[2]);

    let result = sizeA*sizeHeigh/2;

    console.log(`${(result).toFixed(3)}`)
  }
}
area(["circle", "6"]);