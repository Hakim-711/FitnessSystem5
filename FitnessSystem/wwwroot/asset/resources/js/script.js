(function ($) {
    "use strict";

    /* raw script */
    $('.btn-minus').on('click',function () {
        var quantity = $('#qt').val();
        $('#qt').val(--quantity);
    });

    $('.btn-plus').on('click',function () {
        var quantity = $('#qt').val();
        $('#qt').val(++quantity);
    });

    $('.ul-desc-rev-ai li:nth-child(1)').addClass('js--li-b-b');
    $('.ul-desc-rev-ai li:nth-child(1) a span').addClass('js--li-t-color');
    $('.box-product-long-desc').addClass('js-display-1');
    $('.box-product-ai').addClass('js-display-0');
    $('.box-product-rv').addClass('js-display-0');

    $('#p-desc').on('click',function () {
        $('.ul-desc-rev-ai li:nth-child(1)').addClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(1) a span').addClass('js--li-t-color');
        $('.ul-desc-rev-ai li:nth-child(2)').removeClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(2) a span').removeClass('js--li-t-color');
        $('.ul-desc-rev-ai li:nth-child(3)').removeClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(3) a span').removeClass('js--li-t-color');
        $('.box-product-ai').addClass('js-display-0');
        $('.box-product-rv').addClass('js-display-0');
        $('.box-product-rv').removeClass('js-display-1');
        $('.box-product-ai').removeClass('js-display-1');
        $('.box-product-long-desc').removeClass('js-display-1');
        $('.box-product-long-desc').removeClass('js-display-0');
        $('.box-product-long-desc').addClass('js-display-1');
    });

    $('#p-ai').on('click',function () {
        $('.ul-desc-rev-ai li:nth-child(2)').addClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(2) a span').addClass('js--li-t-color');
        $('.ul-desc-rev-ai li:nth-child(1)').removeClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(1) a span').removeClass('js--li-t-color');
        $('.ul-desc-rev-ai li:nth-child(3)').removeClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(3) a span').removeClass('js--li-t-color');
        $('.box-product-long-desc').removeClass('js-display-1');
        $('.box-product-long-desc').addClass('js-display-0');
        $('.box-product-rv').removeClass('js-display-1');
        $('.box-product-rv').addClass('js-display-0');
        $('.box-product-ai').removeClass('js-display-0');
        $('.box-product-ai').addClass('js-display-1');
    });

    $('#p-rev').on('click',function () {
        $('.ul-desc-rev-ai li:nth-child(3)').addClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(3) a span').addClass('js--li-t-color');
        $('.ul-desc-rev-ai li:nth-child(1)').removeClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(1) a span').removeClass('js--li-t-color');
        $('.ul-desc-rev-ai li:nth-child(2)').removeClass('js--li-b-b');
        $('.ul-desc-rev-ai li:nth-child(2) a span').removeClass('js--li-t-color');
        $('.box-product-long-desc').removeClass('js-display-1');
        $('.box-product-long-desc').addClass('js-display-0');
        $('.box-product-ai').removeClass('js-display-1');
        $('.box-product-ai').addClass('js-display-0');
        $('.box-product-rv').removeClass('js-display-0');
        $('.box-product-rv').addClass('js-display-1');
    });

    /*scroll to start*/
    $('.js--scroll-to-plan').on('click',function () {
        $('html,body').animate({scrollTop: $('.js--section-membership').offset().top}, 1000);
    });

    $('.js--scroll-to-start').on('click',function () {
        $('html, body').animate({scrollTop: $('.js--section-features').offset().top}, 1000);
    });

    /* animation on scroll */
    $('.js--wp-features').waypoint(function (direction) {
        $('.js--wp-features').addClass('animated fadeInUp');
    }, {
        offset: '50%'
    });

    $('.js--wp-classes').waypoint(function (direction) {
        $('.js--wp-classes').addClass('animated fadeInUp');
    }, {
        offset: '50%'
    });

    $('.js--wp-trainers').waypoint(function (direction) {
        $('.js--wp-trainers').addClass('animated fadeInUp');
    }, {
        offset: '50%'
    });

    $('.js--wp-popular-news').waypoint(function (direction) {
        $('.js--wp-popular-news').addClass('animated fadeInUp');
    }, {
        offset: '50%'
    });

    $('.js--wp-rp').waypoint(function (direction) {
        $('.js--wp-rp').addClass('animated fadeInUp');
    }, {
        offset: '50%'
    });

    $('.js--wp-facilities').waypoint(function (direction) {
        $('.js--wp-facilities').addClass('animated fadeInLeft');
    }, {
        offset: '50%'
    });

    $('.js--wp-dm').waypoint(function (direction) {
        $('.js--wp-dm').addClass('animated pulse');
    }, {
        offset: '50%'
    });

    /*G MAPS */
    var lat = 38.722252;
    var lng = -9.139337;

    var map = new GMaps({
        div: '.map',
        lat: lat,
        lng: lng,
        zoom: 12
    });
    map.addMarker({
        lat: lat,
        lng: lng,
        title: 'Lima',
        infoWindow: {
            content: '<h6 style="color: #e67e22">BEAST CLUB</h6>'
        }
    });

})(jQuery);