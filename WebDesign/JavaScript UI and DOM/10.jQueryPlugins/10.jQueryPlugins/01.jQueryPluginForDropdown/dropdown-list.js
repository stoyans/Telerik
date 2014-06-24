/// <reference path="_references.js" />

(function ($) {
    $.fn.dropdown = function () {
        var $this = $(this);
        var $dropdownSelect = $("#dropdown").css("display", "none");
        var $options = $this.children('option');
        
        var divContainer = $("<div>").addClass("dropdown-list-container");     
        var ulDropdown = $("<ul>").addClass("dropdown-list-options")
        var $headLI = $("<li>")
            .on("click", animateOptions)
            .appendTo(ulDropdown)
            .text("Choose option");
            

        divContainer.append(ulDropdown);

        for (var i = 0; i < $options.length; i++) {
            var li = $('<li>')
                .addClass("dropdown-list-option")
                .attr("data-value", $options[i].value)
                .html($options[i].innerHTML)
                .on("click", function () {
                    $('.dropdown-list-options li[selected]').removeAttr('selected');
                    $(this).attr("selected", "selected")
                    $headLI.text($(this).text());
                    animateOptions();
                })
                
            ulDropdown.append(li);
        }
        $allOptions = $headLI.siblings().hide();

        function animateOptions() {
            $allOptions.slideToggle();
        }

        $('body').append(divContainer);
    };
}(jQuery));