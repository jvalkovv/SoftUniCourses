function invalidNumber(params) {
  let digit = Number(params[0]);

  if ((digit >= 100 && digit <= 200) || digit === 0) {
  } else {
    console.log("invalid");
  }
}
