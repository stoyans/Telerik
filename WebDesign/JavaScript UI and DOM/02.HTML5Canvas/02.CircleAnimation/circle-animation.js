var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');
var dx = 3;
var dy = 4;
var x = 0;
var y = 0;

function frame() {
    ctx.clearRect(0, 0, 1000, 800);

    circle(x, y, ctx);

    if (x > 1000 || x < 0) {
        dx = -dx;
    }

    if (y > 800 || y < 0) {
        dy = -dy;
    }

    x += dx;
    y += dy;
    
    setTimeout(frame, 10);
}
frame();

function circle(x, y) {

    ctx.beginPath();
    ctx.arc(x, y, 20, 0, Math.PI * 2);
    ctx.fillStyle = 'green';
    ctx.fill();
    ctx.stroke();
}
