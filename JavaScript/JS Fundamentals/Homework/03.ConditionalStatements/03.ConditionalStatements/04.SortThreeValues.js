// Sort 3 real values in descending order
// using nested if statements.

var num1 = 11;
var num2 = 25;
var num3 = 34;

for (i = 0; i < 2; i += 1) {
    if (num1 < num2) {
        var buffer = num2;
        num2 = num1;
        num1 = buffer;
        if (num1 < num3) {
            buffer = num3;
            num3 = num1;
            num1 = buffer;
        }
    }
    else {
        if (num2 < num3) {
            buffer = num3;
            num3 = num2;
            num2 = buffer;
        }
    }
}

console.log('Biggest number is: ' + num1);
console.log('Second biggest number is: ' + num2);
console.log('Third biggest number is: ' + num3);