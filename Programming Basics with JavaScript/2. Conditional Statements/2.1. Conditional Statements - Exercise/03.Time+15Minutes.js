function Time(input) {
    let hours = Number(input[0]);
    let minutes = Number(input[1]);

    let addedMinutes = minutes + 15;

    if (addedMinutes >= 60) {
        hours += 1;
        addedMinutes -= 60;
    }

    if(hours===24)
    {
        hours=0;
    }
    if (addedMinutes < 10) {
        console.log(`${hours}:0${addedMinutes}`);
    }
    else {
        console.log(`${hours}:${addedMinutes}`);
    }
}