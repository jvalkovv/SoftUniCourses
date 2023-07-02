function solve(city) {
  let kvp = Object.entries(city);

  for (let [key, value] of kvp) {
    console.log(`${key} -> ${value}`);
  }
}
solve({
  name: "Plovdiv",
  area: 389,
  population: 1162358,
  country: "Bulgaria",
  postCode: "4000",
});
