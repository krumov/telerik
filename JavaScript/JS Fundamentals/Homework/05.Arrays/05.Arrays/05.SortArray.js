// Sorting an array means to arrange its elements in increasing order.
// Write a script to sort an array. Use the "selection sort" algorithm: 
// Find the smallest element, move it at the first position, find the 
// smallest from the rest, move it at the second position, etc.
// Hint: Use a second array

var array = [1,5,6,3,7,4,5,6,9,5,1,2,8],
    direction = 'ASC',
    inputList = new Array(),
    smallestValueIndex;

for (var i = 0; i < array.length; i++) {

    // current smallest value in the array
    smallestValueIndex = i;

    // check against all other values
    for (var k = i + 1; k < array.length; k++) {

        // new small value, reference its position
        if (compare(array[k], array[smallestValueIndex], direction) === true) {
            smallestValueIndex = k;
        }

    }

    // a new smallest value was assigned, perform a swap !
    if (smallestValueIndex !== i) {
        var tmp = array[i];
        array[i] = array[smallestValueIndex];
        array[smallestValueIndex] = tmp;
    }

}

function compare(a, b, sortDir) {
    if (sortDir === 'ASC') {
        return a < b ? true : b;
    }
    else if (sortDir === 'DESC') {
        return a > b ? true : b;
    }
    return false; // error
}

console.log(array.join(', '));