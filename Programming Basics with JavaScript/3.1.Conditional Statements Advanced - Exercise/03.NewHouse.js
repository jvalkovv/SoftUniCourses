function garden(params) {
  let flower = String([params[0]]);
  let countFlowers = Number(params[1]);
  let budget = Number(params[2]);

  let totalPrice = 0;

  if (flower === "Roses") {
    let price = 5;
    if (countFlowers > 80) {
      totalPrice = price * countFlowers;
      totalPrice *= 0.9;
    }
    else{
        totalPrice = price * countFlowers;
    }
  } else if (flower === "Dahlias") {
    let price = 3.8;
    if (countFlowers > 90) {
      totalPrice = price * countFlowers;
      totalPrice *= 0.85;
    }
    else{
        totalPrice = price * countFlowers;
    }
  } else if (flower === "Tulips") {
    let price = 2.8;
    if (countFlowers > 80) {
      totalPrice = price * countFlowers;
      totalPrice *= 0.85;
    }
    else{
        totalPrice = price * countFlowers;
    }
  } else if (flower === "Narcissus") {
    let price = 3;
    if (countFlowers < 120) {
      totalPrice = price * countFlowers;
      totalPrice *= 1.15;
    }
    else{
        totalPrice = price * countFlowers;
    }
  } else if (flower === "Gladiolus") {
    let price = 2.5;
    if (countFlowers < 80) {
      totalPrice = price * countFlowers;
      totalPrice *= 1.2;
    }
    else{
        totalPrice = price * countFlowers;
    }
  }
  let leftSum = Math.abs(budget - totalPrice);

  if (totalPrice <= budget) {
    console.log(
      `Hey, you have a great garden with ${countFlowers} ${flower} and ${leftSum.toFixed(
        2
      )} leva left.`
    );
  } else if (totalPrice > budget) {
    console.log(`Not enough money, you need ${leftSum.toFixed(2)} leva more.`);
  }
}

