function sequence(params) {
  let initialNumber = Number(params.shift());

  let count = 1;

  while (count <= initialNumber) {
    console.log(count);
    count = count * 2 + 1;
  }
}
sequence(["31"]);
