function solve(params) {
  let meetings = {};

  for (let operator of params) {
    let token = operator.split(" ");
    let weekDay = token[0];
    let firstName = token[1];
    let args = Object.getOwnPropertyNames(meetings);
    if (args.includes(weekDay)) {
      console.log(`Conflict on ${weekDay}!`);
    } else {
      meetings[weekDay] = firstName;
      console.log(`Scheduled for ${weekDay}`);
    }
  }

  for (const key in meetings) {
    console.log(`${key} -> ${meetings[key]}`);
  }
}
solve(["Monday Peter", "Wednesday Bill", "Monday Tim", "Friday Tim"]);
