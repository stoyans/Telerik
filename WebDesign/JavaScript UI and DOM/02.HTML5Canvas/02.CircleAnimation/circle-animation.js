var canvas = document.getElementById('canvas');
var ctx = canvas.getContext('2d');
var dx = 3;
var dy = 4;
var radius = 20;
var x = radius;
var y = radius;


function frame() {
    ctx.clearRect(0, 0, 1000, 800);

    circle(x, y, ctx);

    if (x > 1000-radius || x < radius) {
        dx = -dx;
    }

    if (y > 800 - radius || y < radius) {
        dy = -dy;
    }

    x += dx;
    y += dy;
    
    setTimeout(frame, 1);
}
frame();

function circle(x, y) {

    ctx.beginPath();
    ctx.arc(x, y, radius, 0, Math.PI * 2);
    ctx.fillStyle = 'green';
    ctx.fill();
    ctx.stroke();
}
