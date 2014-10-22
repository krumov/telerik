// Write a script that shows the sign (+ or -) 
// of the product of three real numbers without
// calculating it. Use a sequence of if statements.


var num1 =- 5;
var num2 = -157;
var num3 = 9;

var result;

if (num1 < 0) {
    if (num2 < 0) {
        if (num3 < 0) {
            console.log('Result is negative')
        } else {
            console.log('Result is positive')
        }
    } else {
        if (num3 < 0) {
            console.log('Result is positive')
        } else {
            console.log('Result is negative')
        }
    }
    
} else {
    if (num2 < 0) {
        if (num3 < 0) {
            console.log('Result is positive')
        } else {
            console.log('Result is negative')
        }
    } else {
        if (num3 < 0) {
            console.log('Result is negative')
        } else {
            console.log('Result is positive')
        }
    }
}