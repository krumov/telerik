// Write a script that finds the maximal sequence of equal 
// elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


var array = [1, 5, 7, 5, 2, 2, 2, 3, 6, 4, 4, 5, 6, 6];

var currentCount = 1;
var finalCount = 1;
var currentElement = 0;
var finalElement = 0;
for (var i = 0; i < array.length - 1;) {
    currentCount = 1;
    var currentIndex = i;
    while (array[currentIndex]== array[currentIndex + 1]) {
        currentCount++;
        currentIndex++;
        currentElement = array[i];
    }
    i += currentCount;
    if (currentCount>finalCount) {
        finalCount = currentCount;
        finalElement = currentElement;
    }
}

var arrResult = [];
arrResult.unshift('{');

for (var i = 1; i <= finalCount; i++) {
    arrResult[i] = finalElement;
}

arrResult.push('}');

console.log(arrResult);