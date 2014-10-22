var Renderer = (function () {
    "use strict";

    function drawAll(score) {
        MyCanvas.clear();
        drawScore(score);
        drawSnake();
        drawApple();
    }

    function drawScore(score) {
        MyCanvas.drawText(20, 40, 'Your score - '+ score, 20, "Arial", "darkgreen");
    }

    function drawSnake() {
        var i, x, y;
        var coordinates = Snake.getCoordinates();

        for (i = 0; i < coordinates.length; i += 1) {
            x = coordinates[i].x;
            y = coordinates[i].y;

            if (i < 8) {
                MyCanvas.drawRectangle(x, y, 10, 10, 'black', "darkgreen");
            }
            else {
                MyCanvas.drawRectangle(x, y, 10, 10, 'black', "darkgreen");
            }
        }
    }

    function drawApple() {
        MyCanvas.drawRectangle(Apple.getCoordinate().x, Apple.getCoordinate().y, 10, 10, 'black', 'darkgreen');
    }

    return{
        drawAll:drawAll
    }

})();