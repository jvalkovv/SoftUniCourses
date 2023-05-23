function speed(input) {
  let inputSpeed = Number(input[0]);

  if (inputSpeed <= 10) {
    console.log("slow");
  } else if (inputSpeed > 10 && inputSpeed <= 50) {
    console.log("average");
  } else if (inputSpeed > 50 && inputSpeed <= 150) {
    console.log("fast");
  } else if (inputSpeed > 150 && inputSpeed <= 1000) {
    console.log("ultra fast");
  } else if (inputSpeed > 1000) {
    console.log("extremely fast");
  }
}
speed(["1001 "])