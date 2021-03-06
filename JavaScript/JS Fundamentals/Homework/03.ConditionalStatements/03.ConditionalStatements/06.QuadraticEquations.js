﻿function calculateEquation() {
    var a = parseFloat(document.getElementById('first').value);
    var b = parseFloat(document.getElementById('second').value);
    var c = parseFloat(document.getElementById('third').value);
    var x1;
    var x2;
    var determinant;

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        alert("a, b, c must be numbers");
    }
    else {
        if (a != 0) {
            determinant = b * b - 4 * a * c;
            if (determinant > 0) {
                x1 = (-b + Math.sqrt(determinant)) / (2 * a);
                x2 = (-b - Math.sqrt(determinant)) / (2 * a);
                alert("x1= " + x1 + "; x2= " + x2);
            }
            else if (determinant == 0) {
                x1 = (-b) / (2 * a);
                alert("x1,2 = " + x1);
            }
            else if (determinant < 0) {
                alert("There are no real roots");
            }
        }
        else if (b != 0) {
            x1 = (-c) / b;
            alert("x1,2 = " + x1);
        }
        else {
            alert("No quadratic equation");
        }
    }
}