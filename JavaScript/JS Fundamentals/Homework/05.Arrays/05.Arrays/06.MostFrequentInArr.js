// Write a program that finds the most frequent number in an array. 
// Example:
// {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

var array = [1, 5, 7, 5, 2, 2, 3, 4, 6, 4, 4, 5, 6, 6, 6];

for (var i in array) {
    array[i] = parseInt(array[i], 10);
}
var count = 1,
    finalCount = 1,
    currentElement = array[0],
    finalElement = 0;

for (var i = 0; i < array.length; i++) {
    count = 1;
    currentElement = array[i];
    var tempIndex = i + 1;
    while (tempIndex < array.length) {
        if (array[tempIndex] == currentElement) {
            count++;
        }
        tempIndex++;
    }
    if (count > finalCount) {
        finalCount = count;
        finalElement = currentElement;
    }
}
if (finalCount > 1) {
    console.log("The most frequent number is " + finalElement + " and it appears " + finalCount + " times!");
}
else {
    console.log("The most frequent number is " + array[0] + " and it appears 1 time!");
}