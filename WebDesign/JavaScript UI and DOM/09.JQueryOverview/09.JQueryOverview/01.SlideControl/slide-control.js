/// <reference path="_references.js" />

var slides = [
    "<div>Slide 1</div>",
    "<div>Slide 2</div>",
    "<img src=\"demo.png\"/>",
    "<div>Slide 4</div>",
    "<ul>"+
        "<li> Item 1</li>"+
        "<li> Item 2</li>"+
        "<li> Item 3</li>"+
        "<li> Item 4</li>"+
   "</ul>",
   "<div>Slide 6</div>",
];
var slideIndex = 0;
var maxSlideIndex = slides.length;


$("<div>")
    .attr("id", "wrapper")
    .css({
        "height": "300px",
        "width": "300px",
        "border" : "1px solid"
    })
    .appendTo(document.body)

$("#wrapper").append(slides[0]);

$("<button>")
    .attr("id", "previous")
    .text("Previous")
    .appendTo(document.body)
    .on("click", prevSlide)
       
$("<button>")
    .attr("id", "next")
    .text("Next")
    .css("margin-left", "174px")
    .appendTo(document.body)
    .on("click", nextSlide)

function nextSlide() {
    $("#wrapper").empty();
    slideIndex++;
    if (slideIndex == maxSlideIndex) {
        slideIndex = 0;
    }
    $("#wrapper").append(slides[slideIndex]);
    setTimeout(nextSlide, 5000);
    //clearInterval();
}
nextSlide();

function prevSlide() {
    $("#wrapper").empty();
    slideIndex--;
    if (slideIndex < 0) {
        slideIndex = maxSlideIndex - 1;
    }
    $("#wrapper").append(slides[slideIndex]);
}
