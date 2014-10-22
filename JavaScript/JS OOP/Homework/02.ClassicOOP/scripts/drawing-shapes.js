var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext('2d');

var Rect = (function () {
    function Rect(x, y, width, height) {
        this._x = x;
        this._y = y;
        this._width = width;
        this._height = height;
    }

    Rect.prototype.draw = function () {
        //ctx.strokeStyle = 'rgb(2, 55, 155)';
        ctx.strokeRect(this._x, this._y, this._width, this._height);
    }

    return Rect;
}());

var Circle = (function () {
    function Circle(x, y, r) {
        this._x = x;
        this._y = y;
        this._r = r;
    }

    Circle.prototype.draw = function () {
        ctx.arc(this._x, this._y, this._r, 0, 2 * Math.PI);
        ctx.stroke();
    }

    return Circle;
}());

var Line = (function () {
    function Line(x1, y1, x2, y2) {
        this._x1 = x1;
        this._x2 = x2;
        this._y1 = y1;
        this._y2 = y2;
    }

    Line.prototype.draw = function () {
        ctx.beginPath();
        ctx.moveTo(this._x1, this._y1);
        ctx.lineTo(this._x2, this._y2);
        ctx.stroke();
    }

    return Line;
}());

var rect1 = new Rect(5, 5, 150, 80);
var rect2 = new Rect(50, 50, 150, 80);
var circle1 = new Circle(250, 250, 75);
var line1 = new Line(5, 5, 500, 300);

rect1.draw();
rect2.draw();
circle1.draw();
line1.draw();