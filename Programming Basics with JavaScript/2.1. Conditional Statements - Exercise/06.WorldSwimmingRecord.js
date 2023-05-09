function record(input) {
  let additionalTimeConstant = 12.5;

  let recordToBeat = Number(input[0]);
  let swimmingDistanceInMeters = Number(input[1]);
  let timeInSecondsFor1Meters = Number(input[2]);

  let timeForMeters = swimmingDistanceInMeters * timeInSecondsFor1Meters;
  let additionalTime =
    Math.floor(swimmingDistanceInMeters / 15) * additionalTimeConstant;
  let allTime = additionalTime + timeForMeters;

  if (allTime < recordToBeat) {
    console.log(
      `Yes, he succeeded! The new world record is ${allTime.toFixed(
        2
      )} seconds.`
    );
  } else {
    let diff = Math.abs(recordToBeat - allTime);
    console.log(`No, he failed! He was ${diff.toFixed(2)} seconds slower.`);
  }
}
record(["10464", "1500", "20"]);
