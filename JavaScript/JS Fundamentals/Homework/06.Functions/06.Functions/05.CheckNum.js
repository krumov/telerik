// Write a function that counts how many times given number 
// appears in given array. Write a test function to check if 
// the function is working correctly.

function findNumber(array , number) {
    var counter = 0;

    for (var i = 0; i < array.length; i++) {
        if (array[i]===number) {
            counter++;
        }
    }

    return counter;
}

var testArr = [2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5,
    6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7,21,21];

function test(testArray) {
    console.log(findNumber(testArr, 2));
    console.log(findNumber(testArr, 3));
    console.log(findNumber(testArr, 4));
    console.log(findNumber(testArr, 5));
    console.log(findNumber(testArr, 6));
    console.log(findNumber(testArr, 7));
    console.log(findNumber(testArr, 21));
}

test(testArr);