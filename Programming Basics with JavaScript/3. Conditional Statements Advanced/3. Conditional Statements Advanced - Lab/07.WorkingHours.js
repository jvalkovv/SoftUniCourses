function workingHour(params) {
  let hour = Number(params[0]);
  let day = String(params[1]);

  if (
    day === "Monday" ||
    day === "Tuesday" ||
    day === "Wednsday" ||
    day === "Thursday" ||
    day === "Friday" ||
    day === "Saturday"
  ) {
    if (hour >= 10 && hour <= 18) {
      console.log("open");
    } else {
      console.log("closed");
    }
  } else {
    console.log("closed");
  }
}
