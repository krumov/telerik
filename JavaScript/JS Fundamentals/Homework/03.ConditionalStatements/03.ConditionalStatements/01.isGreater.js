// Write an if statement that examines 
// two integer variables and exchanges their values 
// if the first one is greater than the second one.


var firstNum = 70;
var secondNum = 14;
console.log('First number before: ' + firstNum);
console.log('Second number before: ' + secondNum);

if (firstNum > secondNum) {
    var helper = 0;
    helper = firstNum;
    firstNum = secondNum;
    secondNum = helper;
}

console.log('First number after: ' + firstNum);
console.log('Second number after: ' + secondNum);