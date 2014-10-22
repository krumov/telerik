$.fn.tabs = function () {
    $("#tabs-container").addClass("tabs-container");

    $('#tabs-container').find('.tab-item-content').hide();

    $("#tabs-container").on('click','.tab-item-title',function(){
        $('#tabs-container').find('.tab-item-content').hide();

        $('.tab-item.current').removeClass('current');
        $(this).parent().addClass('current');

        $(this).next().show();
    });
};