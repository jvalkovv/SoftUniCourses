function hotelRoom(params) {
  let month = String(params[0]);
  let countOfNights = Number(params[1]);

  let studioSum = 0;
  let apartmentSum = 0;

  let studioPricePerNight = 0;
  let apartmentPricePerNight = 0;

  if (month === "May" || month === "October") {
    studioPricePerNight = 50;
    apartmentPricePerNight = 65;

    studioSum = countOfNights * studioPricePerNight;
    apartmentSum = countOfNights * apartmentPricePerNight;

    if (countOfNights > 7 && countOfNights <= 14) {
      studioSum *= 0.95;
    } else if (countOfNights > 14) {
      studioSum *= 0.7;
    }
  } else if (month === "June" || month === "September") {
    studioPricePerNight = 75.2;
    apartmentPricePerNight = 68.7;

    studioSum = countOfNights * studioPricePerNight;
    apartmentSum = countOfNights * apartmentPricePerNight;
    if (countOfNights > 14) {
      studioSum *= 0.8;
    }
  } else if (month === "July" || month === "August") {
    studioPricePerNight = 76;
    apartmentPricePerNight = 77;
    studioSum = countOfNights * studioPricePerNight;
    apartmentSum = countOfNights * apartmentPricePerNight;
  }
  if (countOfNights > 14) {
    apartmentSum *= 0.9;
  }

  console.log(`Apartment: ${apartmentSum.toFixed(2)} lv.`);
  console.log(`Studio: ${studioSum.toFixed(2)} lv.`);
}
