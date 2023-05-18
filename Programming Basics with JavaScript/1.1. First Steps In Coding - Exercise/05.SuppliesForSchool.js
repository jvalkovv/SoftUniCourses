function supplier(input) {
    let penPackage = 5.80;
    let markerPackage = 7.20;
    let cleaner = 1.20;

    let penCount = Number(input[0]);
    let markerCount = Number(input[1]);
    let boardCleanerCount = Number(input[2]);
    let percentDiscount = Number(input[3]) / 100;
    let discount = 1 - percentDiscount;
    let penSum = penCount * penPackage;
    let markerSum = markerCount * markerPackage;
    let boardSum = cleaner * boardCleanerCount;

    let sum = penSum + markerSum + boardSum;
    sum *= discount;
    console.log(sum);
}
