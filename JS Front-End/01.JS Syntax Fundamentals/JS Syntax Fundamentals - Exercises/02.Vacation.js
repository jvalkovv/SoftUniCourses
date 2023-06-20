function solve(count, groupOfPeople, dayOfTheWeek) {
  let sum = 0;
  if (groupOfPeople === "Students") {
    if (dayOfTheWeek === "Friday") {
      sum = count * 8.45;
    } else if (dayOfTheWeek === "Saturday") {
      sum = count * 9.8;
    } else if (dayOfTheWeek === "Sunday") {
      sum = count * 10.46;
    }
  } else if (groupOfPeople === "Business") {
    if (count >= 100) {
      if (dayOfTheWeek === "Friday") {
        sum = count * 10.9 - 10 * 10.9;
      } else if (dayOfTheWeek === "Saturday") {
        sum = count * 15.6 - 10 * 15.6;
      } else if (dayOfTheWeek === "Sunday") {
        sum = count * 16 - 10 * 16;
      }
    } else {
      if (dayOfTheWeek === "Friday") {
        sum = count * 10.9;
      } else if (dayOfTheWeek === "Saturday") {
        sum = count * 15.6;
      } else if (dayOfTheWeek === "Sunday") {
        sum = count * 16;
      }
    }
  } else if (groupOfPeople === "Regular") {
    if (dayOfTheWeek === "Friday") {
      sum = count * 15;
    } else if (dayOfTheWeek === "Saturday") {
      sum = count * 20;
    } else if (dayOfTheWeek === "Sunday") {
      sum = count * 22.5;
    }
  }
  if (groupOfPeople === "Students" && count >= 30) {
    sum *= 0.85;
  } else if (groupOfPeople === "Regular" && count >= 10 && count <= 20) {
    sum *= 0.95;
  }
  console.log(`Total price: ${sum.toFixed(2)}`);
}
solve(40, "Regular", "Saturday");
