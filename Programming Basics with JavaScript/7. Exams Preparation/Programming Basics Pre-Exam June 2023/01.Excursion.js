function trip(params) {
    let peopleCount = Number(params.shift());
    let nightCount = Number(params.shift());
    let transportCardsCount = Number(params.shift());
    let museumsTicketsCount = Number(params.shift());

    let nightPrice = 20;
    let transportCardPrice = 1.60;
    let museumsTicketPrice = 6;

    let nightSum = nightCount*nightPrice;
    let transportSum = transportCardPrice * transportCardsCount;
    let museumsTicketSum = museumsTicketsCount*museumsTicketPrice;
    let expensePerPerson = nightSum+transportSum+museumsTicketSum;

    let allPeopleSum = expensePerPerson*peopleCount;

    let additional = allPeopleSum*1.25;

    console.log(additional.toFixed(2));
}
trip(["20",
"14",
"30",
"6"]);