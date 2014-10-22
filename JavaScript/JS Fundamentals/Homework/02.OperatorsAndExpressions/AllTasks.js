// Task 1 - Write an expression that checks if given integer is odd or even.


var num = 8;

if ((num % 2) !== 0) {
    console.log("Number is odd");
} else {
    console.log("Number is even");
}

// Task 2 - Write a boolean expression that checks for given integer if it 
// can be divided (without remainder) by 7 and 5 in the same time.


var num2 = 35;

if ((num2 % 7) !==0 && (num2 %5 !== 0)) {
    console.log("Number is NOT divisable by 7 and 5 at the same time");
} else {
    console.log("\nNumber IS divisable by 7 and 5 at the same time"); // 35 is true
}

// Task 3 - Write an expression that calculates rectangle’s area by given width and height.

var width = 5,
    height = 3;

function rectArea(width,height) {
    return width * height;
}

console.log(rectArea(width, height)); // 15


// Task 4- Write an expression that checks for given integer if its third digit 
// (right-to-left) is 7. E. g. 1732  true.

var num4 = 1234735;

if ((parseInt(num4 / 100) % 10) === 7) {
    console.log("The third number is 7");
} else {
    console.log("The third number is NOT 7");
}

// Task 5 - Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var num5 = 12; // binary 1100 - third bit counting from zero (right to left) is '1'100

num5 = num5 >> 3;

if (num5 % 2 === 0) {
    console.log("3rd bit is 0");
} else {
    console.log("3rd bit is 1");
}

// Task 6 - Write an expression that checks if given print (x,  y) is within a circle K(O, 5).

var  x = 3;
var y = 1;
var radius = 5;

if ((x*x + y*y) <= radius*radius){
    console.log("Point with coordinates " + x + " and " + y + " is within the circle K(0,5)");
} else {
    console.log("Point with coordinates " + x +" and " + y + " is out of the circle K(0,5)");
}

// Task 7 - Write an expression that checks if given positive integer number n (n ≤ 100) is prime. 
// E.g. 37 is prime.

var num7 = 11;

if (num7 === 2 || num7 === 3 || num7 === 5 || num7 === 7) {
    console.log("The number " + num7 + " is prime");
} else {

    if (parseInt(num7 % 2) === 0 || parseInt(num7 % 3) === 0 || parseInt(num7 % 4) === 0 || parseInt(num7 % 5) === 0 || parseInt(num7 % 6) === 0
        || parseInt(num7 % 7) === 0 || parseInt(num7 % 8) === 0 || parseInt(num7 % 9) === 0 || parseInt(num7 % 10) === 0) {

        console.log("The number " + num7 + " is not prime");
    } else {
        console.log("The number " + num7 + " is prime");
    }
}

