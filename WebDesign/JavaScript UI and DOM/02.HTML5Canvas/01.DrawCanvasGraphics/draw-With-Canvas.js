function draw() {
    var canvas = document.getElementById('canvas-context');
    var canvasContext = canvas.getContext('2d');

    //DRAW HOUSE
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
    canvasContext.moveTo(910, 150);
    canvasContext.quadraticCurveTo(890, 158, 870, 150);
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
    canvasContext.lineCap = 'round';
    canvasContext.lineJoin = 'round';
    canvasContext.moveTo(760, 600);
    canvasContext.lineTo(760, 490);
    canvasContext.moveTo(760, 490);
    canvasContext.quadraticCurveTo(700, 450, 640, 490);
    canvasContext.moveTo(640, 490);
    canvasContext.lineTo(640, 600);
    canvasContext.stroke();
    canvasContext.closePath();

    //DRAW HUMAN
    //draw head
    canvasContext.beginPath();
    canvasContext.arc(200, 300, 60, 0, 2 * Math.PI);
    canvasContext.strokeStyle = '#37B6FA';
    canvasContext.fillStyle = '#9DECF5';
    canvasContext.fill();
    canvasContext.stroke();
    canvasContext.closePath();
    //draw eyes
    canvasContext.beginPath();
    canvasContext.save();
    canvasContext.scale(1, 0.7);
    canvasContext.arc(170, 400, 10, 0, 2 * Math.PI, false);
    canvasContext.stroke();
    canvasContext.closePath();
    canvasContext.beginPath();
    canvasContext.arc(220, 400, 10, 0, 2 * Math.PI, false);
    canvasContext.stroke();
    canvasContext.closePath();

    canvasContext.beginPath();
    canvasContext.scale(0.6, 2.2);
    canvasContext.arc(278, 182, 3, 0, 2 * Math.PI, false);
    canvasContext.strokeStyle = '#37B6FA';
    canvasContext.fillStyle = '#37B6FA';
    canvasContext.fill();
    canvasContext.stroke();
    canvasContext.closePath();
    
    canvasContext.beginPath();
    canvasContext.arc(361, 182, 3, 0, 2 * Math.PI, false);
    canvasContext.strokeStyle = '#37B6FA';
    canvasContext.fillStyle = '#37B6FA';
    canvasContext.fill();
    canvasContext.closePath();
    canvasContext.stroke();
    canvasContext.restore();

    //draw mouth
    canvasContext.beginPath();
    canvasContext.save();
    canvasContext.rotate(5 * Math.PI / 180);
    canvasContext.scale(2, 0.6);
    canvasContext.arc(110, 530, 12, 0, 2 * Math.PI);
    canvasContext.strokeStyle = '#37B6FA';
    canvasContext.stroke();
    canvasContext.restore();
    canvasContext.closePath();

    //draw nose
    canvasContext.beginPath();
    canvasContext.moveTo(196, 278);
    canvasContext.lineTo(187, 315);
    canvasContext.lineTo(202, 315);
    canvasContext.lineWidth = 2;
    canvasContext.stroke();
    canvasContext.closePath();    

    //draw hat
    canvasContext.beginPath();
    canvasContext.save();
    canvasContext.scale(2, 0.4);
    canvasContext.arc(100, 610, 35, 0, 2 * Math.PI);
    canvasContext.strokeStyle = 'black';
    canvasContext.fillStyle = '#0E53B3';
    canvasContext.fill();
    canvasContext.stroke();
    canvasContext.restore();
    canvasContext.closePath();

    canvasContext.beginPath();
    canvasContext.fillStyle = '#0E53B3';
    canvasContext.moveTo(240, 233);
    canvasContext.lineTo(240, 150);
    canvasContext.moveTo(240, 150);
    canvasContext.quadraticCurveTo(205, 130, 165, 150);
    canvasContext.quadraticCurveTo(205, 170, 240, 150);
    canvasContext.moveTo(165, 150);
    canvasContext.lineTo(165, 233);
    canvasContext.quadraticCurveTo(200, 260, 240, 233);
    canvasContext.lineTo(240, 150);
    canvasContext.fill();
    canvasContext.strokeStyle = 'black';
    canvasContext.stroke();
    canvasContext.closePath();

    //draw bike
    //no time TODO:
}
draw();