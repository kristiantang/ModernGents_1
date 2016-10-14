$(document).ready(function () {
    var paddingCol = 0;
    function cssHeight() {
        var cw = $('.col-md-2').width();
        $('.indexCategory').css({
            'height': cw + paddingCol + 'px'
        });
    }
    cssHeight();
    $(window).resize(cssHeight);
});