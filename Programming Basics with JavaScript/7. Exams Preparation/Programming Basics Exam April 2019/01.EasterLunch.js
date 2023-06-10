function easter(params) {
  let breadPrice = 3.2;
  let eggsPricePer12 = 4.35;
  let cookiesPrice = 5.40;
  let eggsColorPricePerEgg = 0.15;

  let breadCount = Number(params.shift());
  let barkEggsCount = Number(params.shift());
  let kilogramsCookies = Number(params.shift());

  let breadFinalPrice = breadCount * breadPrice;
  let eggsFinalPrice = barkEggsCount * eggsPricePer12;
  let colorFinalPrice = eggsColorPricePerEgg * barkEggsCount * 12;
  let cookiesPriceFinalPrice = kilogramsCookies * cookiesPrice;
  let sum =
    breadFinalPrice + eggsFinalPrice + colorFinalPrice + cookiesPriceFinalPrice;
  console.log(`${sum.toFixed(2)}`);
}
easter(["3", "2", "3"]);
