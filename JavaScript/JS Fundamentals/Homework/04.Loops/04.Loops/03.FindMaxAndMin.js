// Write a script that finds the max and min number from
// a sequence of numbers


var numbers = [1, 5, 7, 87, 6, 3, 12, 65, 45, 32, 65, 4, 2, 9],
    maxNum = -Number.MAX_VALUE,
    minNum = Number.MAX_VALUE;

for (var i = 0; i < numbers.length; i++) {
    if (numbers[i] > maxNum) {
        maxNum = numbers[i];
    }
}

for (var i = 0; i < numbers.length; i++) {
    if (numbers[i] < minNum) {
        minNum = numbers[i];
    }
}

alert('The max and min numbers form the array in the code are respectively: ' + maxNum + ' and ' + minNum);