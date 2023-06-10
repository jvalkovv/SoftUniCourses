function exam(params) {
  let studentCount = Number(params.shift());

  let topStudent = 0;
  let goodStudent = 0;
  let middleStudent = 0;
  let failStudent = 0;
  let allMarks = 0;
  for (let index = 1; index <= studentCount; index++) {
    let currGrade = Number(params.shift());
    if (currGrade >= 5) {
      topStudent++;
      allMarks+=currGrade;
    } else if (currGrade >= 4 && currGrade < 5) {
      goodStudent++;
      allMarks+=currGrade;
    } else if (currGrade >= 3 && currGrade < 4) {
      middleStudent++;
      allMarks+=currGrade;
    } else if (currGrade < 3) {
      failStudent++;
      allMarks+=currGrade;
    }
  }

  let topStudentPercent = (topStudent / studentCount) * 100;
  let goodStudentPercent = (goodStudent / studentCount) * 100;
  let middleStudentPercent = (middleStudent / studentCount) * 100;
  let failStudentPercent = (failStudent / studentCount) * 100;
  let averageResult = allMarks / studentCount;

  console.log(`Top students: ${topStudentPercent.toFixed(2)}%`);
  console.log(`Between 4.00 and 4.99: ${goodStudentPercent.toFixed(2)}%`);
  console.log(`Between 3.00 and 3.99: ${middleStudentPercent.toFixed(2)}%`);
  console.log(`Fail: ${failStudentPercent.toFixed(2)}%`);
  console.log(`Average: ${averageResult.toFixed(2)}`);
}
exam([
  "10",
  "3.00",
  "2.99",
  "5.68",
  "3.01",
  "4",
  "4",
  "6.00",
  "4.50",
  "2.44",
  "5",
]);
