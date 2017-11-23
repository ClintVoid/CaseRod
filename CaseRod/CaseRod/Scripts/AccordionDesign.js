
$(function () {
    "use strict";
    $('.info').first().show().animate({
        width: '40%'
    });

    $('.item').click(function () {
        $(this)
          .next().show().animate({
              width: '40%'
          })
          .siblings(".info").animate({
              width: 0
          });

    });

});