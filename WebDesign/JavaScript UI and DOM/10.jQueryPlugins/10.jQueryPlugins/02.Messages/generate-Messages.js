/// <reference path="_references.js" />

(function ($) {
    $.fn.messageBox = function () {
        var $this = $(this);
        var $buttons = $this.children('button');
        var $successButton = $this.children().eq(0);
        var $errorButton = $this.children().eq(1);

        return {
            success: function () {
                displayMessage();

                return $this;
            },
            error: function () {
                displayMessage();

                return $this;
            }
        };

        var $divMessage = $('<div>')
        function displayMessage(message) {
            $divMessage
                .appendTo(document.body)
                .attr("id", "success")
                .css({
                    "position": "absolute",
                    "top": "20px",
                    "left": "500px",
                    "opacity": "0",
                })
                .text(message)
                .animate({
                    opacity: 1,
                }, 1000);
        }
    };
}(jQuery));

$successButton.on("click", displayMessage);
$errorButton.on("click", displayMessage);
$('#error-btn').on('click', function () {
    $this.messageBox().error('ERROR', 'red')
});

$('#success-btn').on('click', function () {
    msgBox.success('SUCCESS', 'green')
});