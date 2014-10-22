// Write a JavaScript function that finds how many times 
// a substring is contained in a given text 
// (perform case insensitive search).
// Example: The target substring is "in". 

//The text is as follows:

// We are living in an yellow submarine. We don't have anything else. 
// Inside the submarine is very tight. So we are drinking all the day. 
// We will move out of it in 5 days.

// The result is: 9.

function checkText(parameters) {

    var str = document.querySelector('#input').value;
    var lookFor = document.querySelector('#lookFor').value;

    alert(countWords(str, lookFor) + " times!");

    function countWords(inputString, lookFor) {
        var counter = 0;
        var index = 0;

        while (index != -1 && index < inputString.length) {
            // Convert to lower case and search.
            index = inputString.toLowerCase().indexOf(lookFor, index);
            if (index != -1) {
                counter++;
                index += lookFor.length - 1;
            }
        }

        return counter;
    }
}