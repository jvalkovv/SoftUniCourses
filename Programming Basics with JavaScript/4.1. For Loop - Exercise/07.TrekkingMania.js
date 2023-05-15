function trekkingMania(params) {
  let countOfGroups = Number(params.shift());

  let countMusala = 0;
  let countMonblan = 0;
  let countKilimanjaro = 0;
  let countK2 = 0;
  let countEverest = 0;
  let allPeople = 0;
  for (let index = 1; index <= countOfGroups; index++) {
    let peopleInGroups = Number(params.shift());
    if (peopleInGroups <= 5) {
      countMusala+=peopleInGroups;
    } else if (peopleInGroups >= 6 && peopleInGroups <= 12) {
      countMonblan+=peopleInGroups;
    } else if (peopleInGroups >= 13 && peopleInGroups <= 25) {
      countKilimanjaro+=peopleInGroups;
    } else if (peopleInGroups >= 26 && peopleInGroups <= 40) {
      countK2+=peopleInGroups;
    } else if (peopleInGroups >= 41) {
      countEverest+=peopleInGroups;
    }
    allPeople+=peopleInGroups;
  }

  let musalaPercent = countMusala/allPeople*100;
  let monblanPercent = countMonblan/allPeople*100;
  let kilimanjaroPercent = countKilimanjaro/allPeople*100;
  let k2Percent = countK2/allPeople*100;
  let everestPercent = countEverest/allPeople*100;

  console.log(`${musalaPercent.toFixed(2)}%`);
  console.log(`${monblanPercent.toFixed(2)}%`);
  console.log(`${kilimanjaroPercent.toFixed(2)}%`);
  console.log(`${k2Percent.toFixed(2)}%`);
  console.log(`${everestPercent.toFixed(2)}%`);
}
trekkingMania(["5",
"25",
"41",
"31",
"250",
"6"])
;