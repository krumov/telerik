// Write a JavaScript function reverses string and returns it
// Example: "sample"  "elpmas".

function reverseText() {

    var input = document.querySelector('#input').value;

    var output = input.split("").reverse().join("");

    alert(output);
}

