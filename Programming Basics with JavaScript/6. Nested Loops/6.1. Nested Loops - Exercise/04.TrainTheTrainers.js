function courses(params) {
  let judgeCount = Number(params.shift());
  let presentationName = String(params.shift());
  let sumOfAllGrades = 0;
  let presentationCount = 0;
  while (true) {
    let gradeForPresentation = 0;
    if (presentationName === "Finish") {
      break;
    }
    for (let j = 1; j <= judgeCount; j++) {
      let grades = Number(params.shift());
      gradeForPresentation += grades;
      presentationCount++;
    }
    sumOfAllGrades += gradeForPresentation;
    let avgGradeForPresentation = gradeForPresentation / judgeCount;
    console.log(`${presentationName} - ${avgGradeForPresentation.toFixed(2)}.`);
    presentationName = String(params.shift());
  }
  let finalGrades = sumOfAllGrades / presentationCount;
  console.log(`Student's final assessment is ${finalGrades.toFixed(2)}.`);
}
courses([
  "2",
  "Objects and Classes",
  "5.77",
  "4.23",
  "Dictionaries",
  "4.62",
  "5.02",
  "RegEx",
  "2.88",
  "3.42",
  "Finish",
]);
