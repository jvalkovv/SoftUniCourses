function commissions(params) {
  let city = String(params[0]);
  let money = Number(params[1]);

  let result = 0;
  if (money >= 0 && money <= 500) {
    if (city === "Sofia") {
      result = money * 0.05;
    } else if (city === "Varna") {
      result = money * 0.045;
    } else if (city === "Plovdiv") {
      result = money * 0.055;
    } else {
      console.log("error");
      return;
    }
  } else if (money > 500 && money <= 1000) {
    if (city === "Sofia") {
      result = money * 0.07;
    } else if (city === "Varna") {
      result = money * 0.075;
    } else if (city === "Plovdiv") {
      result = money * 0.08;
    }
    else{
        console.log("error");
        return;
    }
  } else if (money > 1000 && money <= 10000) {
    if (city === "Sofia") {
      result = money * 0.08;
    } else if (city === "Varna") {
      result = money * 0.1;
    } else if (city === "Plovdiv") {
      result = money * 0.12;
    }
    else{
        console.log("error");
        return;
    }
  } else if (money > 10000) {
    if (city === "Sofia") {
      result = money * 0.12;
    } else if (city === "Varna") {
      result = money * 0.13;
    } else if (city === "Plovdiv") {
      result = money * 0.145;
    } else {
      console.log("error");
      return;
    }
  }
  else{
    console.log("error");
        return;
  }

  console.log(`${result.toFixed(2)}`);
}