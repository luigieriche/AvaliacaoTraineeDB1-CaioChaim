$(document).ready(function () {

    $(".menu-link").on("click", function () {
        debugger;
        $(".menu-link").removeClass("selected");
        $(this).addClass("selected");

    })

    $("#logo").on("click", function () {

        $(".menu-link").removeClass("selected");
            
    })

});