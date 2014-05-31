function getDivsInsideDivsQuery() {
    var insideDivs = document.querySelectorAll('div > div');
    console.log(insideDivs.length);
}

function getDivsInsideDivsGetTagName() {
    var insideDivs = document.getElementsByTagName('div > div');
    console.log(insideDivs.length);
}
getDivsInsideDivsQuery();
getDivsInsideDivsGetTagName();