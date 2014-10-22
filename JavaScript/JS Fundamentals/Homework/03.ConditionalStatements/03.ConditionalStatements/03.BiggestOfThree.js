// Write a script that finds the biggest of
// three integers using nested if statements.

var num1 = 1;
var num2 = 2;
var num3 = 3;

if (num1 > num2 && num1 > num3) {
    console.log('Biggest number is: ' + num1)
} else if (num2 > num1 && num2 > num3) {
    console.log('Biggest number is: ' + num2)
} else if (num3 > num1 && num3 > num2) {
    console.log('Biggest number is: ' + num3)
}

