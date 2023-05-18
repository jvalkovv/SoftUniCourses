function bookSeeker(params) {
  let searchedBook = String(params.shift());
  let currBook = String(params.shift());
  let count = 0;
  while (searchedBook !== currBook) {
    if (currBook === "No More Books") {
      console.log("The book you search is not here!");
      console.log(`You checked ${count} books.`);
      return;
    }
    count++;
    currBook = String(params.shift());
  }
  console.log(`You checked ${count} books and found it.`);
}
bookSeeker([
  "Bourne",
  "True Story",
  "Forever",
  "More Space",
  "The Girl",
  "Spaceship",
  "Strongest",
  "Profit",
  "Tripple",
  "Stella",
  "The Matrix",
  "Bourne",
]);
