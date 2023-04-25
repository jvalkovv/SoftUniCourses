function cost(input)
{
 let priceForSquareKM = 7.61;
 let discountPercent = 18/100;
 
 let kilometers = Number(input[0]);

 let yardPrice = priceForSquareKM*kilometers;

let discount = yardPrice*discountPercent;
let finalPrice = yardPrice-discount;

console.log(`The final price is: ${finalPrice} lv.`);
console.log(`The discount is: ${discount} lv.`)
}

cost(["550"])