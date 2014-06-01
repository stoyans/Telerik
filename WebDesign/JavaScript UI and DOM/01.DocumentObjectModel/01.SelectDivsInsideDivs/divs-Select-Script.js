function getDivsInsideDivsQuery() {
    var insideDivs = document.querySelectorAll('div > div');
    for (var i = 0; i < insideDivs.length; i++) {
        console.log(insideDivs[i].innerHTML);
    }
    
    console.log('number of divs directly inside divs are: ' + insideDivs.length);
}

function getDivsInsideDivsGetTagName() {
    var insideDivs = document.getElementsByTagName('div');
    var coundInnerDivs = 0;
    for (var i = 0; i < insideDivs.length; i++) {
        if (insideDivs[i].parentNode.tagName.toLowerCase() === 'div') {
            console.log(insideDivs[i].innerHTML);
            coundInnerDivs++;
        }
    }
    console.log('number of divs directly inside divs are: ' + coundInnerDivs);
}
getDivsInsideDivsQuery();
getDivsInsideDivsGetTagName();