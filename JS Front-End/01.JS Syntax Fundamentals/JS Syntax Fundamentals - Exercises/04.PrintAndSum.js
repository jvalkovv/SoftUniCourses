function solve(start, end) {
  let sum = 0;
  let arr = "";

  for (let index = start; index <= end; index++) {
    arr += `${index} `;
    sum += index;
  }
  console.log(arr);
  console.log(`Sum: ${sum}`);
}
solve(5, 10);
