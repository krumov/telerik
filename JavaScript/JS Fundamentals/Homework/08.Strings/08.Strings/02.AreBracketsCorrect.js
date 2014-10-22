// Write a JavaScript function to check if in a given expression 
// the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d).
// Example of incorrect expression: )(a+b)).

function checkBrackets() {
    
    var input = document.querySelector('#input').value;
    var countBrackets = 0;

    var inputArr = input.split('');

    for (var i = 0; i < inputArr.length; i++) {

        if (inputArr[i] === "(") {  //if we have opening bracket it`s OK
            countBrackets++;
        }
        if (inputArr[i] === ")") {
            countBrackets--;  //if we have closing bracket before opening one, it`s a mistake and countBrackets will be<0
        }
        if (countBrackets < 0) {
            return alert('Brackets are NOT correct');
        }
    }

    if (countBrackets === 0) { //if in the end opening and closing brackets are the same number, the brackets are correctly p
        return alert('Brackets are correct');
    } else {
        return alert('Brackets are NOT correct');
    }
}

