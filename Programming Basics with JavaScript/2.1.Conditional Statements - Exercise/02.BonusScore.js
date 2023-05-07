function scores(input) {
    let bonus = 0;
    let givenNumber = Number(input[0]);

    if (givenNumber <= 100) {
        bonus += 5;
    }
    if (givenNumber > 100 && givenNumber <= 1000) {
        bonus += givenNumber * 0.20;
    }
    if (givenNumber > 1000) {
        bonus += givenNumber * 0.10;
    }
    if (givenNumber % 2 === 0) {
        bonus += 1;
    }
    else if (givenNumber % 10 == 5) {
        bonus += 2;
    }

    console.log(bonus);
    let result = givenNumber + bonus;
    console.log(result);
}