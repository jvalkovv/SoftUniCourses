function exam(params) {
  let badGrades = Number(params.shift());
  let countBadGrades = 0;
  let countGoodGrade = 0;
  let totalGrades = 0;
  let lastTask = "";
  while (true) {
    let taskName = String(params.shift());
    if (taskName === "Enough") {
      break;
    }
    let currScore = Number(params.shift());
    if (currScore <= 4) {
      countBadGrades++;
      totalGrades += currScore;
    } else {
      totalGrades += currScore;
      countGoodGrade++;
    }
    if (countBadGrades === badGrades) {
      console.log(`You need a break, ${countBadGrades} poor grades.`);
      return;
    }
    lastTask = taskName;
  }
  let allGrades = countBadGrades + countGoodGrade;
  let avgGrades = totalGrades / allGrades;
  console.log(`Average score: ${avgGrades.toFixed(2)}`);
  console.log(`Number of problems: ${allGrades}`);
  console.log(`Last problem: ${lastTask}`);
}
exam(["2", "Income", "3", "Game Info", "6", "Best Player", "4"]);
