function projectCreatio(input){

    let hoursForOneProject = 3;
    let name = String(input[0]);
    let numberProject = Number(input[1]);
    let neededHours = hoursForOneProject*numberProject; 
console.log(`The architect ${name} will need ${neededHours} hours to complete ${numberProject} project/s.`)    
}

projectCreatio(["Georgi",4]);