// Write a script that finds the lexicographically
// smallest and largest property in document, window 
// and navigator objects

var arr1 = [window, navigator, document];

for (var i = 0; i < 3; i++) {
    var outTxt = "";
    var arr;
    for (var property in arr1[i]) {
        outTxt += property + " ";
    }
    arr = outTxt.split(" ");
    arr.sort();

    if (i === 0) {
        console.log("Window properties:\nMin: " + arr[1] + ";\nMax: " + arr[arr.length - 1] + ";");
    } else if (i === 1) {
        console.log("Navigator properties:\nMin: " + arr[1] + ";\nMax: " + arr[arr.length - 1] + ";");

    }else if (i === 2) {
        console.log("Document properties:\nMin: " + arr[1] + ";\nMax: " + arr[arr.length - 1] + ";");

    }

}