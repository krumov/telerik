// Write a script that finds the maximal increasing 
// sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.


var array = [1, 5, 7, 5, 2, 2, 2, 3, 4, 6, 4, 4, 5, 6, 6];

var currentCount = 1;
var finalCount = 1;
for (var i = 0; i < array.length - 1;) {
    var tempArr = [];
    tempArr.push(array[i]);
    currentCount = 1;
    var tempIndex = i;
    while (array[tempIndex] == (array[tempIndex + 1]) - 1) {
        currentCount++;
        tempIndex++;
        tempArr.push(array[tempIndex]);

    }
    i += currentCount;
    if (currentCount > finalCount) {
        finalCount = currentCount;
        var finallArr = [].concat(tempArr);
    }

}

finallArr.unshift('{');
finallArr.push('}');

console.log(finallArr);