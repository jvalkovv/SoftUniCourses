function easterTrip(params) {
  let destination = String(params.shift());
  let chosenDate = String(params.shift());
  let nightCount = Number(params.shift());

  let price = 0;

  if (destination === "France") {
    if (chosenDate === "21-23") {
      price = 30;
    } else if (chosenDate === "24-27") {
      price = 35;
    } else if (chosenDate === "28-31") {
      price = 40;
    }
  } else if (destination === "Italy") {
    if (chosenDate === "21-23") {
      price = 28;
    } else if (chosenDate === "24-27") {
      price = 32;
    } else if (chosenDate === "28-31") {
      price = 39;
    }
  } else if (destination === "Germany") {
    if (chosenDate === "21-23") {
      price = 32;
    } else if (chosenDate === "24-27") {
      price = 37;
    } else if (chosenDate === "28-31") {
      price = 43;
    }
  }

  let finalPrice = nightCount * price;
  console.log(`Easter trip to ${destination} : ${finalPrice.toFixed(2)} leva.`);
}
easterTrip(["France", "28-31", "8"]);
