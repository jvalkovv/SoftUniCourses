function calculator(input)
{
 let depositSum = Number(input[0]);
 let period = Number(input[1])/100;
 let yearPercent = Number(input[2]);

 let num = depositSum + (period*(depositSum*yearPercent)/12)
 console.log(num);
}
