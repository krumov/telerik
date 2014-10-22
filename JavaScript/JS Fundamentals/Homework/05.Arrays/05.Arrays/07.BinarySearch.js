// Write a program that finds the index of given element in a 
// sorted array of integers by using the binary search algorithm 
// (find it in Wikipedia).


function findIndex(values, target) {
    return binarySearch(values, target, 0, values.length - 1);
};

function binarySearch(values, target, start, end) {
    if (start > end) { return -1; } //does not exist

    var middle = Math.floor((start + end) / 2);
    var value = values[middle];

    if (value > target) { return binarySearch(values, target, start, middle - 1); }
    if (value < target) { return binarySearch(values, target, middle + 1, end); }
    return middle; //found!
}


console.log('The index of the number 20 in the array is: ' +
    findIndex([1, 4, 6, 7, 12, 13, 15, 18, 19, 20, 22, 24], 20));

