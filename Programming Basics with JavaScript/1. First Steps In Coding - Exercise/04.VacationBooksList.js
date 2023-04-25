function list(input)
{
let bookPapers = Number(input[0]);
let bookPapersPerHour = Number(input[1]);
let maxDaysCount = Number(input[2]);

let readTimeHour = bookPapers/bookPapersPerHour;
let result = readTimeHour/maxDaysCount;

console.log(result);

}
