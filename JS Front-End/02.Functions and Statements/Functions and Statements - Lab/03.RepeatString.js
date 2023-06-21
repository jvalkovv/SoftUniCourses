function repeatString(text, countOfRepeat) {
  let result = "";
  for (let i = 1; i <= countOfRepeat; i++) {
    result += text;
  }
  console.log(result);
}
repeatString("abc", 3);
