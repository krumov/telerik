// Write a script that prints all the numbers from 1 to N

function printOneToN() {

    var n = parseInt(document.querySelector('#inputNumber').value);

    for (var i = 0; i < n; i++) {
        console.log(i + 1);
    }

    alert('Check the console(F12)');

}