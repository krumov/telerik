
var canvasField = document.getElementById("field");
var context = canvasField.getContext("2d");
var xCoordinate = 25,
    yCoordinate = 25,
    xDirection = 1,
    yDirection = 1,
    radius = 25;

setInterval(move, 20);

function move() {
    context.beginPath();
    context.arc(xCoordinate, yCoordinate, radius * 2, 0, 2 * Math.PI);
    context.fillStyle = "#7DF47D";
    context.fill();

    xCoordinate += xDirection;
    yCoordinate += yDirection;
    if (xCoordinate === radius || xCoordinate === canvasField.width - radius) {
        xDirection *= -1;
    }
    if (yCoordinate === radius || yCoordinate === canvasField.height - radius) {
        yDirection *= -1;
    }

    context.beginPath();
    context.arc(xCoordinate, yCoordinate, radius, 0, 2 * Math.PI);
    context.fillStyle = "#2E792E";
    context.fill();
    context.stroke();
}
