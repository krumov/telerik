// Write a script that finds the greatest of given 5 variables.

function findBiggest() {
    var num1 = parseFloat(document.querySelector('#first').value)
    var num2 = parseFloat(document.querySelector('#second').value)
    var num3 = parseFloat(document.querySelector('#third').value)
    var num4 = parseFloat(document.querySelector('#forth').value)
    var num5 = parseFloat(document.querySelector('#fifth').value)

   var maxNum = Math.max(num1, num2, num3, num4, num5);

    alert('The biggest number is: ' + maxNum);
}