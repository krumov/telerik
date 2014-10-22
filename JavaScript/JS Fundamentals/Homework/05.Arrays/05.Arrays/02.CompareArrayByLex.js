// Write a script that compares two char arrays 
// lexicographically (letter by letter).


var arr1 = ['a', 's', 'i', 'o', 'q', 'z', 'f', 'c', 'v'],
    arr2 = ['a', 'x', 'i', 'o', 'd', 'z', 'f', 'c', 'b'];


var biggestLenght = Math.max(arr1.length, arr2.length);

for (var i = 0; i < biggestLenght; i++) {
    if (arr1[i] === arr2[i]) {

        console.log(arr1[i] + " is the same as " + arr2[i] + " lexicographyclly!");
    }else if (arr1[i] > arr2[i]) {
        console.log(arr1[i] + " is after " + arr2[i] + " lexicographyclly!");
    }
    else {
        console.log(arr1[i] + " is before " + arr2[i] + " lexicographyclly!");
    }
}
