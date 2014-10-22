// Write a function that reverses the digits of given decimal number. 
// Example: 256  652


function reverseDigits() {

    var number = parseInt(document.querySelector('#input').value);

    var y = number.toString();
    var z = y.split("").reverse().join("");

    alert(z);
}