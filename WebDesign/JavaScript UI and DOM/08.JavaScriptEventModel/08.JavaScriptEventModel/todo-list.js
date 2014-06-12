var btn = document.getElementById("add");
var divWrapper = document.getElementById("wrapper");

function createInput() {
    var input = document.createElement("input");
    input.style.width = "150px";
    input.id = "inputItem";
    divWrapper.appendChild(input);
    divWrapper.appendChild(btn);
}
createInput();

function getValue() {
    var item = document.getElementById("inputItem").value;
    return item;
}

var list = document.createElement("ol");
var emptyList = document.createElement("div");

btn.onclick = function displayList() {
    if (getValue() == '') {
        emptyList.innerHTML = "Add something in the list!";
        document.body.appendChild(emptyList);
    }
    else {
        var li = document.createElement("li");
        li.innerHTML = getValue();
        list.appendChild(li);

    }
    divWrapper.appendChild(list);

}
displayList();