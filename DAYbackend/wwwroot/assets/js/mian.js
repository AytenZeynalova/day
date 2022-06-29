$(window).scroll(function(){
    if($(this).scrollTop() > 100){
        $('.navbar-sec').addClass('sticky')
    } else{
        $('.navbar-sec').removeClass('sticky')
    }
});


