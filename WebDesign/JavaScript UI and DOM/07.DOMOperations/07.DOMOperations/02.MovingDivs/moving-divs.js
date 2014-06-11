var divs = Array(5);
var centerX = 100,
centerY = 150,
radius = 100;
var angle = 0;

function createDivs() {
    for (var i = 0; i < 5; i++) {

        x = (centerX + radius * Math.cos(2 * Math.PI * i / 5)),
        y = (centerY + radius * Math.sin(2 * Math.PI * i / 5)),
        circleDiv = document.createElement('div');
        circleDiv.classList.add('circle');
        circleDiv.id = 'circle' + i;
        circleDiv.style.left = x + 'px';
        circleDiv.style.top = y + 'px';
        document.body.appendChild(circleDiv);
        divs[i] = circleDiv;
    }
}

var functionTimer = setInterval(function moveDivs() {
    angle++;
    if (angle == 360) {
        angle = 0;
    }

    for (var i = 0; i < divs.length; i++) {

        var addition = (360 / divs.length) * i;

        var left = centerX + Math.cos((2 * 3.14 / 180) * (angle + addition)) * radius;
        var right = centerY + Math.sin((2 * 3.14 / 180) * (angle + addition)) * radius;
        divs[i].style.left = left + "px";
        divs[i].style.top = right + "px";
    }
}, 100);

createDivs();
