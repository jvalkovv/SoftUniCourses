function operations(params) {
  let n1 = Number(params[0]);
  let n2 = Number(params[1]);
  let operator = String(params[2]);

  let result = 0;
  let evenOrOdd;
  if (n2 === 0) {
    console.log(`Cannot divide ${n1} by zero`);
    return;
  }
  if (operator === "+") {
    result = n1 + n2;
    if (result % 2 === 0) {
      evenOrOdd = "even";
    } else {
      evenOrOdd = "odd";
    }
    console.log(`${n1} ${operator} ${n2} = ${result} - ${evenOrOdd}`);
  } else if (operator === "-") {
    result = n1 - n2;
    if (result % 2 === 0) {
      evenOrOdd = "even";
    } else {
      evenOrOdd = "odd";
    }
    console.log(`${n1} ${operator} ${n2} = ${result} - ${evenOrOdd}`);
  } else if (operator === "*") {
    result = n1 * n2;
    if (result % 2 === 0) {
      evenOrOdd = "even";
    } else {
      evenOrOdd = "odd";
    }
    console.log(`${n1} ${operator} ${n2} = ${result} - ${evenOrOdd}`);
  } else if (operator === "/") {
    result = n1 / n2;
    console.log(`${n1} ${operator} ${n2} = ${result.toFixed(2)}`);
  } else if (operator === "%") {
    result = n1 % n2;
    console.log(`${n1} ${operator} ${n2} = ${result}`);
  }
}
operations(["112", "0", "/"]);
