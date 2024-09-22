﻿$(document).ready(function () {
    $('.owl-carousel').owlCarousel({
        loop: true,
        nav: true,
        margin: 0,
        autoplay: true,
        autoplayTimeout: 2000,
        autoplayHoverPause: true,
        responsive: {

            200: {
                items: 1
            },

            340: {
                items: 1
            },

            380: {
                items: 2
            },

            700: {
                items: 2
            },
            1000: {
                items: 3
            },
            1500: {
                items: 4
            },
            2000: {
                items: 5
            },
            3000: {
                items: 6
            }
        }
    });
});