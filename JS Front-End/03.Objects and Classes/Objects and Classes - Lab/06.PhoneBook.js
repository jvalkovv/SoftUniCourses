function solve(params) {
  let phoneBook = {};

  for (let iterator of params) {
    let token = iterator.split(" ");
    let firstName = token[0];
    let phoneNumber = token[1];
    phoneBook[firstName] = phoneNumber;
  }

  for (const key in phoneBook) {
    console.log(`${key} -> ${phoneBook[key]}`);
  }
}

solve([
  "Tim 0834212554",
  "Peter 0877547887",
  "Bill 0896543112",
  "Tim 0876566344",
]);
