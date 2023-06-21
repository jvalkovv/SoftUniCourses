function solve(searchedWord, params) {
  let paramsArr = params.split(" ");
  for (let k = 0; k < paramsArr.length; k++) {
    let element = paramsArr[k];
    if (searchedWord.toLowerCase() === element.toLowerCase()) {
      console.log(searchedWord);
      break;
    }
    if (!paramsArr.includes(searchedWord)) {
      console.log(`${searchedWord} not found!`);
      break;
    }
  }
}
solve("Javascript", "Javascript is the best programming language");
