function readtext(params) {
  let text = String(params.shift());

  while (text !== "Stop") {
    console.log(`${text}`);
    text = String(params.shift());
  }
}
readtext([
  "Nakov",
  "SoftUni",
  "Sofia",
  "Bulgaria",
  "SomeText",
  "Stop",
  "AfterStop",
  "Europe",
  "HelloWorld",
]);
