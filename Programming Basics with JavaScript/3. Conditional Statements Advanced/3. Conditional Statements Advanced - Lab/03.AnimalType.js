function animalClass(animal) {
    
    let type = String([animal[0]]);

    switch (type) {
        case "dog":
            console.log("mammal");
            break;
    case "snake":
    case "crocodile":
    case "tortoise":
        console.log("reptile");
        break;
        default:
            console.log("unknown");
            break;
    }
}