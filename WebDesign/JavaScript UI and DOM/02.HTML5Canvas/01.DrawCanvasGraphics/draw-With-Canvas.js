function draw() {
    var canvas = document.getElementById('canvas-context');
    var canvasContext = canvas.getContext('2d');

    //draw body house
    canvasContext.beginPath();
    canvasContext.rect(600, 300, 380, 300);
    canvasContext.fillStyle = "#FF96B9";
    canvasContext.fill();
    canvasContext.lineWidth = 3;
    canvasContext.stroke();
    canvasContext.closePath();    

    //draw windows
    canvasContext.beginPath();
    canvasContext.rect(630, 330, 140, 90);
    canvasContext.fillStyle = 'black';
    canvasContext.fill();
    canvasContext.stroke();
    canvasContext.rect(810, 330, 140, 90);
    canvasContext.fillStyle = 'black';
    canvasContext.fill();
    canvasContext.stroke();
    canvasContext.rect(810, 450, 140, 90);
    canvasContext.fillStyle = 'black';
    canvasContext.fill();
    canvasContext.strokeStyle = 'black';
    canvasContext.stroke();
    canvasContext.closePath();

    canvasContext.beginPath();
    canvasContext.moveTo(700, 330);
    canvasContext.lineTo(700, 450);
    canvasContext.moveTo(630, 380);
    canvasContext.lineTo(770, 380);
    canvasContext.strokeStyle = '#FF96B9';
    canvasContext.lineWidth = 3;
    canvasContext.moveTo(880, 330);
    canvasContext.lineTo(880, 430);
    canvasContext.moveTo(810, 380);
    canvasContext.lineTo(960, 380);
    canvasContext.moveTo(880, 450);
    canvasContext.lineTo(880, 550);
    canvasContext.moveTo(810, 495);
    canvasContext.lineTo(960, 495);
    canvasContext.stroke();
    canvasContext.closePath();

    //draw roof
    canvasContext.beginPath();
    canvasContext.moveTo(600, 300);
    canvasContext.lineTo(788, 100);
    canvasContext.lineTo(980, 300);
    canvasContext.strokeStyle = 'black';
    canvasContext.fillStyle = '#FF96B9';
    canvasContext.fill();
    canvasContext.lineWidth = 3;
    canvasContext.closePath();
    canvasContext.stroke();

    //draw chimney
    canvasContext.beginPath();
    canvasContext.moveTo(870, 250);
    canvasContext.lineTo(870, 150);
    canvasContext.quadraticCurveTo(890, 140, 910, 150);
    canvasContext.lineTo(910, 250);
    canvasContext.fillStyle = '#FF96B9';
    canvasContext.fill();
    canvasContext.stroke();
    canvasContext.closePath(); 
       
    //draw door
    canvasContext.beginPath();
    canvasContext.moveTo(700, 600);
    canvasContext.lineTo(700, 470);
    canvasContext.strokeStyle = 'black';
    canvasContext.closePath();
    canvasContext.stroke();

    canvasContext.beginPath();
    canvasContext.arc(680, 560, 5, 0, 2 * Math.PI, false);
    canvasContext.strokeStyle = 'black';
    canvasContext.closePath();
    canvasContext.stroke();

    canvasContext.beginPath();
    canvasContext.arc(720, 560, 5, 0, 2 * Math.PI, false);
    canvasContext.strokeStyle = 'black';
    canvasContext.stroke();

    canvasContext.beginPath();
    canvasContext.moveTo(760, 600);
    canvasContext.lineTo(760, 490);
    canvasContext.moveTo(760, 490);
    canvasContext.quadraticCurveTo(700, 450, 640, 490);
    canvasContext.moveTo(640, 490);
    canvasContext.lineTo(640, 600);
    canvasContext.stroke();
}
draw();