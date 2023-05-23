function outfit(params) {
  let degrees = Number(params[0]);
  let dayTime = String(params[1]);

  let neededOutfit = "";
  let neededShoes = "";

  if (dayTime === "Morning") {
    if (degrees >= 10 && degrees <= 18) {
      neededOutfit = "Sweatshirt";
      neededShoes = "Sneakers";
    } else if (degrees > 18 && degrees <= 24) {
      neededOutfit = "Shirt";
      neededShoes = "Moccasins";
    } else if (degrees >= 25) {
      neededOutfit = "T-Shirt";
      neededShoes = "Sandals";
    }
  } else if ((dayTime === "Afternoon")) {
    if (degrees >= 10 && degrees <= 18) {
      neededOutfit = "Shirt";
      neededShoes = "Moccasins";
    } else if (degrees > 18 && degrees <= 24) {
      neededOutfit = "T-Shirt";
      neededShoes = "Sandals";
    } else if (degrees >= 25) {
      neededOutfit = "Swim Suit";
      neededShoes = "Barefoot";
    }
  } else if ((dayTime === "Evening")) {
    if (degrees >= 10 && degrees <= 18) {
      neededOutfit = "Shirt";
      neededShoes = "Moccasins";
    } else if (degrees > 18 && degrees <= 24) {
      neededOutfit = "Shirt";
      neededShoes = "Moccasins";
    } else if (degrees >= 25) {
      neededOutfit = "Shirt";
      neededShoes = "Moccasins";
    }
  }

  console.log(
    `It's ${degrees} degrees, get your ${neededOutfit} and ${neededShoes}.`
  );
}
