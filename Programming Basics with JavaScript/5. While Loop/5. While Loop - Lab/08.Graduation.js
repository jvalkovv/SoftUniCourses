function graduation(params) {
  let studentName = String(params.shift());
  let count = 0;
  let grade = 1;
  let result = 0;
  while (true) {
    let currGrade = Number(params.shift());
    if (currGrade >= 4) {
      result += currGrade;
      if (grade >= 12) {
        break;
      }
      grade++;
    }
    if (currGrade < 4) {
      count++;
      if (count > 1) {
        console.log(`${studentName} has been excluded at ${grade} grade`);
        return;
      }
    }
  }
  let avgGrade = result / grade;
  console.log(
    `${studentName} graduated. Average grade: ${avgGrade.toFixed(2)}`
  );
}
