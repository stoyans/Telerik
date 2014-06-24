function createImagesPreviewer(selector, items) {
    var rootDiv = document.querySelector(selector);
    
    var filter = document.createElement('span');
    filter.innerHTML = 'filter';
    filter.style.paddingLeft = '50px';

    var input = document.createElement('input');
    input.style.width = '120px';

    var divTitle = document.createElement('div');
    divTitle.innerHTML = items[0].title;
    divTitle.style.textAlign = 'center';
    divTitle.style.fontSize = '24px';
    divTitle.style.fontWeight = 'bold';
    divTitle.style.paddingBottom = '10px';

    var divDisplayItem = document.createElement('div');
    divDisplayItem.style.width = '550px';
    divDisplayItem.style.height = '400px';
    divDisplayItem.style.cssFloat = 'left';
    divDisplayItem.appendChild(divTitle);

    var divListItems = document.createElement('div');
    divListItems.style.width = '150px';
    divListItems.style.height = '400px';
    divListItems.style.overflow = 'scroll';
    divDisplayItem.style.cssFloat = 'left';
    divListItems.appendChild(filter);
    divListItems.appendChild(input);

    rootDiv.appendChild(divDisplayItem);
    rootDiv.appendChild(divListItems);

    createItems(items);
    var firstImage = setInitialImage(items[0]);
    divDisplayItem.appendChild(firstImage);

    function createItems(images) {

        for (var i = 0; i < images.length; i++) {
            var divSingleItem = document.createElement('div');
            divSingleItem.innerHTML = images[i].title;
            divSingleItem.style.textAlign = 'center';
            var image = createImage(images[i]);
            divSingleItem.appendChild(image);
            divSingleItem.style.width = '120px';
            divSingleItem.addEventListener('mouseover', onBoxMouseover);
            divSingleItem.addEventListener('mouseout', onBoxMouseout);
            image.addEventListener('click', onBoxClick);
            divListItems.appendChild(divSingleItem);
        }
        
    }

    function changeDisplayImage(image) {
        var selectedImg = document.createElement('img');
        selectedImg.src = image.src;
        selectedImg.style.width = '500px';
        selectedImg.style.height = '350px';
        return selectedImg;
    }

    function changeDisplayTitle(image) {
        var parentDiv = image.parentNode;
        var selectedTitle = parentDiv.textContent;
        return selectedTitle;
    }

    function createImage(currentImage) {
        var img = document.createElement('img');
        img.src = currentImage.url;
        img.style.width = '120px';
        img.style.height = '80px';
        return img;
    }

    function setInitialImage(firstItem) {
        var initialImg = document.createElement('img');
        initialImg.src = firstItem.url;
        initialImg.style.width = '500px';
        initialImg.style.height = '350px';
        return initialImg;
    }

    function onBoxClick(ev) {
        var removeImg = divDisplayItem.childNodes[1];
        var removeTitle = divDisplayItem.childNodes[0];
        divDisplayItem.removeChild(removeImg);
        divTitle.innerHTML = '';
        divDisplayItem.appendChild(changeDisplayImage(this));
        divTitle.innerHTML = (changeDisplayTitle(this));
    }

    function onBoxMouseover() {
        this.style.backgroundColor = 'lightgray';
    }

    function onBoxMouseout() {
        this.style.backgroundColor = '';
    }
}