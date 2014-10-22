$.fn.gallery = function (picsOnRow) {

    picsOnRow = picsOnRow || 4;

    var rowWidth = 250 * picsOnRow + (0.25*250);

    $('.gallery-list').css('width',rowWidth + 'px');

    $('#gallery').addClass('gallery');

    $('.selected').hide();

    $('.gallery-list').on('click','img',function(){

        $image = $(this);

        currentImgNum = parseInt($image.attr('data-info'));

        replaceImages(currentImgNum);

        $('.selected').show();
        $('.gallery-list').addClass('blurred');
        $('.selected').addClass('disabled-background');

    });

    $('.selected').on('click', '#current-image', function(){
        $('.selected').hide();
        $('.gallery-list').removeClass('blurred');
    });

    $('.selected').on('click', '#previous-image', function(){
        $image = $(this);

        currentImgNum = parseInt($image.attr('data-info'));

        replaceImages(currentImgNum);
    });

    $('.selected').on('click', '#next-image', function(){
        $image = $(this);

        currentImgNum = parseInt($image.attr('data-info'));

        replaceImages(currentImgNum);
    });

    function replaceImages(imageNum){
        if ( imageNum < 2){
            $prevImage = $('.image-container img[data-info=' + 12 +']');

        }else{
            $prevImage = $('.image-container img[data-info=' + (imageNum-1) +']');
        }
        if(currentImgNum>11){
            $nextImage = $('.image-container img[data-info=' + 1 +']');
        }else{
            $nextImage = $('.image-container img[data-info=' + (imageNum+1) +']');
        }

        $('#current-image').replaceWith($image.clone());
        $('.current-image img').attr('id','current-image');

        $('#previous-image').replaceWith($prevImage.clone());
        $('.previous-image img').attr('id','previous-image');

        $('#next-image').replaceWith($nextImage.clone());
        $('.next-image img').attr('id','next-image');
    }
};