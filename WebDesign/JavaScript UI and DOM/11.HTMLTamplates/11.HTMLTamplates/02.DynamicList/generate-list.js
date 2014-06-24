var options = [{
    value: 1,
    text: 'One'
}, {
    value: 2,
    text: 'Two'
}, {
    value: 3,
    text: 'Three'
}, {
    value: 4,
    text: 'Four'
}, {
    value: 5,
    text: 'Five'
}];


var templateNode = document.getElementById("options");
var templateString = templateNode.innerHTML;
var template = Handlebars.compile(templateString);

var articleHTML = template({
    options: options
});

document.body.innerHTML = articleHTML;