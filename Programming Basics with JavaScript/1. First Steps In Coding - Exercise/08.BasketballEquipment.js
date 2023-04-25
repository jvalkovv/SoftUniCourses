function Equipment(input) {
 let yearTax = Number(input[0]);
  let sneakersPrice = yearTax - yearTax * 0.4;
  let basketballEquipment = sneakersPrice- sneakersPrice * 0.2;
  let basketballBall = basketballEquipment/4;
  let basketballAcessories = basketballBall/5;

  let allCost = yearTax+sneakersPrice+basketballEquipment+basketballBall+basketballAcessories;

  console.log(allCost)
}

Equipment(["365 "]);
