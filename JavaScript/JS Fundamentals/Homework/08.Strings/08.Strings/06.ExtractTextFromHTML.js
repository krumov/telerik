// Write a function that extracts the content of a html page given
// as text. The function should return anything that is in a tag, without the tags:

// <html><head><title>Sample site</title></head><body><div>text<div>more 
// text</div>and more...</div>in body</body></html>

// result:
// Sample sitetextmore textand more...in body

var inputString = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

function ParseHtml(str) {
    var inTag = false;
    var result = [];

    // Check input
    var input = str || "";

    for (var i = 0; i < input.length; i++) {
        if (input[i] === "<") {
            inTag = true;
            continue;
        }
        else if (input[i] === ">") {
            inTag = false;
            continue;
        }
        else if (inTag === false) {
            // In text.
            result.push(input[i]);
        }
    }

    return result.join('');
}

// Print result
console.log(ParseHtml(inputString));