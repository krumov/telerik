var sliderInt = 1;
var sliderNext = 2;
$(document).ready(function () {
    $('#1').fadeIn(300);
    startSlider();
});
function startSlider() {
    count = $('#slider > img').size();
    loop = setInterval(function () {
        if (sliderNext > count) {
            sliderNext = 1;
            sliderInt = 1;
        }
        $('#slider>img').fadeOut(300);
        $('#' + sliderNext).fadeIn(300);
        sliderInt = sliderNext;
        sliderNext++;
    },3000)
}
function onButPrev() {
    newSlide = sliderInt - 1;
    showSlide(newSlide);
};
function onButNext() {
    newSlide = sliderInt + 1;
    showSlide(newSlide);
};
function stopLoop() {
    window.clearInterval(loop)
};


function showSlide(id) {
    stopLoop();
    if (id > count) {
        id = 1;
    }
    else if(id<1){
        id=count;
    }
    $('#slider>img').fadeOut(300);
    $('#' + id).fadeIn(300);

    sliderInt = id;
    sliderNext = id + 1;
    startSlider();
};