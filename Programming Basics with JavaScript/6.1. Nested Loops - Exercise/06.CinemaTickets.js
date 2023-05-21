function cinema(params) {
  let allTicket = 0;
  let allStudentTicketCount = 0;
  let allStandardTicketCount = 0;
  let allKidTicketCount = 0;
  let isFinish = false;
  while (true) {
    let movieName = String(params.shift());
    if (isFinish || movieName == "Finish") {
      break;
    }
    let freeSpot = Number(params.shift());
    let studentTicketCount = 0;
    let standardTicketCount = 0;
    let kidTicketCount = 0;
    let ticket = 0;
    while (true) {
      if (ticket === freeSpot) {
        break;
      }
      let ticketType = String(params.shift());
      if (ticketType === "End") {
        break;
      }
      if (ticketType === "Finish") {
        isFinish = true;
        break;
      }
      if (ticketType === "student") {
        studentTicketCount++;
      } else if (ticketType === "standard") {
        standardTicketCount++;
      } else if (ticketType === "kid") {
        kidTicketCount++;
      }
      ticket = studentTicketCount + standardTicketCount + kidTicketCount;
    }
    allStudentTicketCount += studentTicketCount;
    allStandardTicketCount += standardTicketCount;
    allKidTicketCount += kidTicketCount;
    let ticketForCurrentMovie =
      studentTicketCount + standardTicketCount + kidTicketCount;
    allTicket += ticketForCurrentMovie;
    let moviePercent = (ticketForCurrentMovie / freeSpot) * 100;
    console.log(`${movieName} - ${moviePercent.toFixed(2)}% full.`);
  }
  console.log(`Total tickets: ${allTicket}`);
  let studentPercent = (allStudentTicketCount / allTicket) * 100;
  console.log(`${studentPercent.toFixed(2)}% student tickets.`);
  let standardPercent = (allStandardTicketCount / allTicket) * 100;
  console.log(`${standardPercent.toFixed(2)}% standard tickets.`);
  let kidPercent = (allKidTicketCount / allTicket) * 100;
  console.log(`${kidPercent.toFixed(2)}% kids tickets.`);
}
cinema([
  "Shutter Island",
  "9",
  "standard",
  "standard",
  "standard",
  "student",
  "student",
  "student",
  "kid",
  "kid",
  "kid",
  "Rush",
  "9",
  "standard",
  "standard",
  "standard",
  "student",
  "student",
  "student",
  "kid",
  "kid",
  "kid",
  "Deadpool",
  "9",
  "standard",
  "standard",
  "standard",
  "student",
  "student",
  "student",
  "kid",
  "kid",
  "kid",
  "Finish",
]);

[
  "Shutter Island",
  "9",
  "standard",
  "standard",
  "standard",
  "student",
  "student",
  "student",
  "kid",
  "kid",
  "kid",
  "Rush",
  "9",
  "standard",
  "standard",
  "standard",
  "student",
  "student",
  "student",
  "kid",
  "kid",
  "kid",
  "Deadpool",
  "9",
  "standard",
  "standard",
  "standard",
  "student",
  "student",
  "student",
  "kid",
  "kid",
  "kid",
  "Finish",
];
