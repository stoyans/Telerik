/// <reference path="_references.js" />

$("#header")
    .css({
        "position": "relative",
        "top": "15px"
    })
    .css("background", "green")
    .css("width", "100px")

$('<button />')
    .css({
        "position": "absolute",
        "left": "10px",
        "top": "5px"
    })
    .text("button")
    .addClass('btn-success')
    .html('Add Element before div')
    .prependTo(document.body)
    .click(function() {
        $("<div>")
            .css({
                "background": "red",
                "height": "100px"
            })
        .prependTo("#header")
    })

$('<button />')
    .text("button")
    .css({
        "position": "absolute",
        "left": "200px",
        "top":"5px"
    })
    .addClass('btn-success')
    .html('Add Element after div')
    .appendTo(document.body)
    .click(function () {
        $("<div>")
            .css({
                "background": "red",
                "height": "100px"
            })
        .appendTo("#header")
    })

