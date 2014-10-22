// Write a function that makes a deep copy of an object
// The function should work for both primitive and reference types

var objectOne = {
    a: 5,
    b: 6,
    c: "f",
}

var objectTwo = Object.create(objectOne);
for (var i in objectTwo) {
    console.log(objectTwo[i]);
}

function clone(obj) {
    if (obj == null || "Object" != typeof obj) {
        return obj;
    }

    if (obj instanceof Array) {
        var copy = [];
        for (var i = 0 ; i < obj.length ; i++) {
            copy[i] = clone(obj[i]);
        }
        return copy;
    }

    if (obj instanceof Object) {
        var copy = {};
        for (var attr in obj) {
            if (obj.hasOwnProperty(attr)) {
                copy[attr] = clone(obj[attr]);
            }
        }
        return copy;
    }
    throw new Error("Unable copy format!");
}

var c = clone(objectOne);

for (var i in objectOne) {
    console.log(objectOne[i]);
}