function ontime(params) {
  let hourStartExam = Number(params[0]);
  let minuteStartExam = Number(params[1]);
  let arriveHour = Number(params[2]);
  let arriveMinute = Number(params[3]);

  let examTime = hourStartExam * 60 + minuteStartExam;
  let arriveTime = arriveHour * 60 + arriveMinute;

  let diff = examTime - arriveTime;
  let earlyHour;
  let earlyMin;
  let lateHour;
  let lateMin;

  if (diff >= 0 && diff <= 30) {
    if (diff == 0) {
      console.log("On time");
    } else {
      console.log("On time");
      console.log(`${diff} minutes before the start`);
    }
  } else if (diff > 30) {
    earlyHour = Math.floor(diff / 60);
    earlyMin = diff % 60;

    if (diff > 30 && diff <= 59) {
      console.log("Early");
      console.log(`${diff} minutes before the start`);
    } else if (earlyMin <= 10) {
      console.log("Early");
      console.log(`${earlyHour}:0${earlyMin} hours before the start`);
    } else {
      console.log("Early");
      console.log(`${earlyHour}:${earlyMin} hours before the start`);
    }
  } else {
    diff = Math.abs(diff);
    lateHour = Math.floor(diff / 60);
    lateMin = diff % 60;

    if (diff <= 59) {
      console.log("Late");
      console.log(`${diff} minutes after the start`);
    } else if (lateMin <= 10) {
      console.log("Late");
      console.log(`${lateHour}:0${lateMin} hours after the start`);
    } else {
      console.log("Late");
      console.log(`${lateHour}:${lateMin} hours after the start`);
    }
  }
}
ontime(["9",
"30",
"10",
"35"]);
