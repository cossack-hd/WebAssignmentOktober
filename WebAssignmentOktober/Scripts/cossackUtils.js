slides_num = 1;
current_slide = 0;

function initSlides(timer) {
    if (current_slide < slides_num) {
        window.setTimeout(moveSlides, timer);
    }
    else {
        window.setTimeout(moveSlidesDefault, timer);
        current_slide = 0;
    }
}


function moveSlides() {
    current_slide++;
    $('.inner-window').animate({
        right: "+=300px"
    }, 2000);
    initSlides(6000);
}

function moveSlidesDefault() {
    $('.inner-window').animate({
        right: "0px"
    }, 2000);
    initSlides(6000);
}
