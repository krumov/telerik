// Write a function that finds all the occurrences of word in a text
// The search can case sensitive or case insensitive
// Use function overloading


var text = "this is a sample text This is a test this is boring This is very boring";
var word = "this";
var counter = 0;
var wordLength = word.length;
var index = text.indexOf(word, index);
var counter2 = 0;
while (index !== -1) {
    counter++;
    index += wordLength;
    index = text.indexOf(word, index);
}
console.log("The count of word '" + word + "' is: " + counter);
   