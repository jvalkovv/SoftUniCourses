function easterCompetition(params) {
  let maxPoint = 0;
  let userNameMaxPoint = "";
  let countOfBread = Number(params.shift());
  let allPoint = 0;
  for (let index = 1; index <= countOfBread; index++) {
    let cmd = String(params.shift());
    let authorName = cmd;
    let pointPerAuthor = 0;
    let input = params.shift();
    while (input !== "Stop") {
      let currPoint = Number(input);
      pointPerAuthor += currPoint;
      input = params.shift();
    }
    if (pointPerAuthor > maxPoint) {
      maxPoint = pointPerAuthor;
      userNameMaxPoint = authorName;
      console.log(`${authorName} has ${pointPerAuthor} points.`);
      console.log(`${userNameMaxPoint} is the new number 1!`);
    } else {
      console.log(`${authorName} has ${pointPerAuthor} points.`);
    }
  }
  console.log(`${userNameMaxPoint} won competition with ${maxPoint} points!`);
}
easterCompetition([
  "3",
  "Chef Manchev",
  "10",
  "10",
  "10",
  "10",
  "Stop",
  "Natalie",
  "8",
  "2",
  "9",
  "Stop",
  "George",
  "9",
  "2",
  "4",
  "2",
  "Stop",
]);
