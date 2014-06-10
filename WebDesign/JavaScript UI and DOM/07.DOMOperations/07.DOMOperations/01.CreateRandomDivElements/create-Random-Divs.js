function getValue() {
    var num = document.getElementById("input").value;
    return num;
}

function createDiv() {
    var fragmentDiv = document.createDocumentFragment('div');
    for (var i = 0; i < getValue(); i++) {
        var div = document.createElement("div");
        div.style.width = random() + "px";
        div.style.height = random() + "px";
        div.style.color = getRandomColor();
        div.style.borderColor = getRandomColor();
        div.style.background = getRandomColor();
        div.style.borderWidth = getBorder() + "px";
        div.style.borderStyle = "solid";
        div.style.position = "absolute";
        div.style.borderRadius = getBorder() + "px";
        div.style.left = random() + "px";
        div.style.top = random() + "px";
        div.innerHTML = "div";
        fragmentDiv.appendChild(div);
    }
    document.body.appendChild(fragmentDiv);
}
createDiv();

function random() {
    return Math.floor((Math.random() * 500) + 20);
}
function getRandom() {
    return Math.floor((Math.random() * 100) + 20);
}
function getBorder() {
    return Math.floor((Math.random() * 20) + 1);
}
function getRandomColor() {
    var letters = '0123456789ABCDEF'.split('');
    var color = '#';
    for (var i = 0; i < 6; i++) {
        color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
}

function onStopButtonClick() {
    var elementsToRemove = document.getElementsByTagName('div');
    while (elementsToRemove.length > 0) {
        document.body.removeChild(elementsToRemove[0]);
    }
}