// Write a function that removes all elements with a given value
// Attach it to the array type
// Read about prototype and how to attach methods


Array.prototype.removeAll = function (element) {
    var newArr = [];
    for (var i in this) {
        if (this[i] != element) {
            newArr.push(this[i]);
        }
    }
    return newArr;
}

var arr = [1, 2, 1, 4, 1, "1", 3, 4, 1, 111, 3, 2, 1, "1"];

var finalArr = arr.removeAll(1);

for (var i in finalArr) {
    console.log(finalArr[i]);
}