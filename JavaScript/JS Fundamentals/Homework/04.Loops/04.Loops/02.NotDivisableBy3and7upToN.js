// Write a script that prints all the numbers from 1 to N,
// that are not divisible by 3 and 7 at the same time

function checkNum() {

    var n = parseInt(document.querySelector('#inputNumber').value);
    var result = 'The numbers you are looking for are: ';
    if (n < 21) {
        alert('there are no numbers divisable by 3 and 7');
    } else {
        for (var i = 1; i <= n; i++) {
            if ((i % 3 === 0) && (i % 7 === 0)) {
                result += ', ' + i;
            }
        }

        alert(result);
    }
}