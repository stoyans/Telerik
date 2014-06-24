/// <reference path="_references.js" />

$("<input>")
    .appendTo(document.body)
    .attr("id", "color")
    .attr("type", "color")

$("<button>")
    .html("change backgroud")
    .appendTo(document.body)
    .click(function () {
        var colorValue = $("#color").val()
        $("body").css("background", colorValue)
    })