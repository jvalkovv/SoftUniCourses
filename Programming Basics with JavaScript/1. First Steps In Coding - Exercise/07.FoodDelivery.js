function delivery(input){

    let chickenMenuPrice = 10.35;
    let fishMenuPrice = 12.40;
    let veganMenuPrice = 8.15;

    let chickenMenuCount = Number(input[0]);
    let fishMenuCount = Number(input[1]);
    let veganMenuCount = Number(input[2]);

    let chickenPrice = chickenMenuCount*chickenMenuPrice;
    let fishPrice = fishMenuCount*fishMenuPrice;
    let veganPrice = veganMenuCount*veganMenuPrice;

    let menuPrice = chickenPrice+fishPrice+veganPrice;
    let desertPrice =  menuPrice*0.20;

    let deliveryPrice = 2.50;

    let totalSum = menuPrice+desertPrice+deliveryPrice;

    console.log(totalSum)

}

delivery(["2 ","4 ","3 "]);