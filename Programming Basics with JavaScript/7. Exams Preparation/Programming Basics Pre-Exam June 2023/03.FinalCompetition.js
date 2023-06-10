function competition(params) {
  let dancerCount = Number(params.shift());
  let points = Number(params.shift());
  let season = String(params.shift());
  let place = String(params.shift());

  let reward = 0;

  if (place === "Bulgaria") {
    reward = dancerCount * points;
    if (season === "summer") {
      reward *= 0.95;
    } else if (season === "winter") {
      reward *= 0.92;
    }
  } else if (place === "Abroad") {
    reward = dancerCount * points;
    reward *= 1.5;
    if (season === "summer") {
      reward *= 0.9;
    } else if (season === "winter") {
      reward *= 0.85;
    }
  }
  let donationSum = reward * 0.75;
  let leftReward = reward - donationSum;
  let moneyPerDancer = leftReward / dancerCount;

  console.log(`Charity - ${donationSum.toFixed(2)}`);
  console.log(`Money per dancer - ${moneyPerDancer.toFixed(2)}`);
}
competition(["25", "98", "winter", "Bulgaria"]);
