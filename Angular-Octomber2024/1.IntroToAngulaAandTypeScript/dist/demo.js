"use strict";
let id = 96;
let companyName = "Somestring";
console.log(`${id} -> ${companyName}`);
let person = [1, 'Brad', true];
console.log(person);
var Direction;
(function (Direction) {
    Direction[Direction["Up"] = 0] = "Up";
    Direction[Direction["Down"] = 1] = "Down";
    Direction[Direction["Left"] = 2] = "Left";
    Direction[Direction["Right"] = 3] = "Right";
})(Direction || (Direction = {}));
console.log(Direction.Up);
//Object
const user = {
    id: 15,
    name: "John"
};
console.log(user);
