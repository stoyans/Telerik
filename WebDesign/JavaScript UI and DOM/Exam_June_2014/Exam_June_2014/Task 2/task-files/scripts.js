/// <reference path="_references.js" />

$.fn.gallery = function () {
    var $gallery = $(this);
    $gallery.addClass('gallery');
    $gallery.find('.previous-image').hide();
    $gallery.find('.current-image').hide();
    $gallery.find('.next-image').hide();
    var $images = $gallery.find('.image-container img');
    var $picIndex = 0;
    for (var i = 0; i < $images.length; i++) {
        console.log($images.eq(i).attr('data-info'));
    }
   // console.log($gallery.find('.image-container img').eq(0).attr('src'));

    $images
		.on('click', function (ev) {
		    $image = $(this);
		    var $currentImage = $gallery.find('#current-image');
		    $currentImage.attr('src', $image.attr('src'));
		    
		    $picIndex = $image.attr('data-info');
		    console.log($picIndex);
		    var $nextImgSrc = $image.parent().next().children().first().attr('src');
		    var $nextImage = $gallery.find('#next-image')
            .on('click', function (ev) {
                $nextItem = $(this);
                var $nextSrc = $image.parent().next().next().children().first().attr('src');
                $nextImage.attr('src', $nextSrc);
            });
		    $nextImage.attr('src', $nextImgSrc);
		    $gallery.find('.current-image').show();
		    $gallery.find('.next-image').show();
		    $gallery.find('.previous-image').show();

		})


};