function calculatePrice(params) {
  let fruit = String(params[0]);
  let day = String(params[1]);
  let count = Number(params[2]);

  let price = 0;

  if (
    day === "Monday" ||
    day === "Tuesday" ||
    day === "Wednesday" ||
    day === "Thursday" ||
    day === "Friday"
  ) {
    if (fruit === "banana") {
      price = count * 2.5;
    } else if (fruit === "apple") {
      price = count * 1.2;
    } else if (fruit === "orange") {
      price = count * 0.85;
    } else if (fruit === "grapefruit") {
      price = count * 1.45;
    } else if (fruit === "kiwi") {
      price = count * 2.7;
    } else if (fruit === "pineapple") {
      price = count * 5.5;
    } else if (fruit === "grapes") {
      price = count * 3.85;
    } else {
      console.log("error");
      return;
    }
  } else if (day === "Saturday" || day === "Sunday") {
    if (fruit === "banana") {
      price = count * 2.7;
    } else if (fruit === "apple") {
      price = count * 1.25;
    } else if (fruit === "orange") {
      price = count * 0.9;
    } else if (fruit === "grapefruit") {
      price = count * 1.6;
    } else if (fruit === "kiwi") {
      price = count * 3;
    } else if (fruit === "pineapple") {
      price = count * 5.6;
    } else if (fruit === "grapes") {
      price = count * 4.2;
    } else {
      console.log("error");
      return;
    }
  } else {
    console.log("error");
    return;
  }

  console.log(`${price.toFixed(2)}`);
}
