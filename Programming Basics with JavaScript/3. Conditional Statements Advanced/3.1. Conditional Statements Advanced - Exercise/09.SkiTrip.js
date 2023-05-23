function trip(params) {
  let daysCount = Number(params[0]);
  let type = String(params[1]);
  let mark = String(params[2]);

  let nights = daysCount - 1;

  let onePersonRoomPrice = 18;
  let apartmenPrice = 25;
  let presidentPrice = 35;

  let sum = 0;
  if (type === "room for one person") {
    sum = nights * onePersonRoomPrice;
  } else if (type === "apartment") {
    sum = nights * apartmenPrice;

    if (daysCount < 10) {
      sum *= 0.7;
    } else if (daysCount >= 10 && daysCount <= 15) {
      sum *= 0.65;
    } else if (daysCount > 15) {
      sum *= 0.5;
    }
  } else if (type === "president apartment") {
    sum = nights * presidentPrice;
    if (daysCount < 10) {
      sum *= 0.9;
    } else if (daysCount >= 10 && daysCount <= 15) {
      sum *= 0.85;
    } else if (daysCount > 15) {
      sum *= 0.8;
    }
  }
  if (mark === "positive") {
    sum *= 1.25;
  } else if (mark === "negative") {
    sum *= 0.9;
  }
  console.log(`${sum.toFixed(2)}`);
}
trip(["30",
"president apartment",
"negative"])
;