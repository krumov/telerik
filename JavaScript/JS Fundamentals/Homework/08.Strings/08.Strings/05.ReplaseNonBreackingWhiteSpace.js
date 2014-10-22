// Write a function that replaces non breaking white-spaces in a text
// with &nbsp;


var inputString = "We are <mixcase>living</mixcase> in a <upcase>yellow " +
    "submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

console.log(inputString);

function EscapeSpaces(str) {
    var result = [];
    result = str.split('');

    for (var i = 0; i < result.length; i++) {
        if (result[i] == " ") {
            result[i] = "&nbsp;";
        }
    }
    
    return result.join('');
}

// Print result
console.log('');
console.log(EscapeSpaces(inputString));