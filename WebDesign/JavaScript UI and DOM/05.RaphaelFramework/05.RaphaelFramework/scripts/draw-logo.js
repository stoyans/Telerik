function raphael() {
    var paper = Raphael('container', 800, 300);
    return paper;
}

function drawTelerikLogo() {
    var paper = raphael();
    logo = paper.path("M 30 105 L 70 70 L 133 143 L 95 178 L 62 142 L 137 70 L 170 105")
	.attr({
	    fill: "none",
	    "stroke-width": 18,
	    stroke: '#5CE600',
	});
    var text = paper.text(420, 150, "Telerik");
    text.attr({ "font-family": "arial", fill: "black", "font-size": 142, "font-weight": "bold" });
    var subText = paper.text(505, 230, "Develop experiences");
    subText.attr({ "font-family": "arial", fill: "black", "font-size": 60 });

    var img = paper.image("img/symbol.png", 640, 125, 30, 30);
}

/*
paper.setStart();

paper.path('M125 75 L150 50 L215 115 L180 150 L145 115 L215 50 L240 75').attr({ stroke: '#5CE600', 'stroke-width': 15 });
paper.text(260, 115, 'Telerik').attr({ stroke: '#000000', 'stroke-width': 4, 'text-anchor': 'start','font-size': '130px', });
paper.text(650, 105, '®').attr({ stroke: '#000000', 'stroke-width': 0, 'text-anchor': 'start', 'font-size': '40px', });
paper.text(287, 200, 'Develop experiences').attr({ stroke: '#000000', 'stroke-width': 0, 'text-anchor': 'start', 'font-size': '56px', });

set = paper.setFinish();
set.attr({
'font-family': 'Arial'
});
*/

function drawYoutubeLogo() {
    var paper = raphael();
    var rect = paper.rect(300, 50, 360, 200, 50);
    rect.attr({
        fill: "#EC2828",
        stroke: "#EC2828"
    });
    var textYou = paper.text(170, 150, "You");
    textYou.attr({ "font-family": "Arial", fill: "black", "font-size": 142, "font-weight": "bold" });
    var textTube = paper.text(480, 150, "Tube");
    textTube.attr({ "font-family": "Arial", fill: "white", "font-size": 142, "font-weight": "bold" });
}