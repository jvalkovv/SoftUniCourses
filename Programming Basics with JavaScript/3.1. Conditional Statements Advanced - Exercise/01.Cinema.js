function tickets(params) {
  let typeOfProjection = String(params[0]);
  let numberOfRows = Number(params[1]);
  let numberOfCol = Number(params[2]);

  let price = 0;

  if (typeOfProjection === "Premiere") {
    price = 12.0;
    price *= numberOfRows * numberOfCol;
  } else if (typeOfProjection === "Normal") {
    price = 7.5;
    price *= numberOfRows * numberOfCol;
  } else if (typeOfProjection === "Discount") {
    price = 5;
    price *= numberOfCol * numberOfRows;
  }

  console.log(`${price.toFixed(2)} leva`);
}

