let id: number = 96;

let companyName: string = "Somestring";

console.log(`${id} -> ${companyName}`);


let person: [number, string, boolean] = [1, 'Brad', true];

console.log(person);


enum Direction {
    Up,
    Down,
    Left,
    Right
}

console.log(Direction.Up);


//Interfaces

interface UserInterfaces {
    id: number,
    name: string
}

//Object
let user: UserInterfaces =
{
    id: 15,
    name: "John"
}

console.log(user);
