//slider js 
var slide = document.getElementsByClassName('slide');
var prev = document.querySelector('.prev');
var next = document.querySelector('.next');
var n = 0;

function disnon() {
    for (var i = 0; i < slide.length; i++) {
        slide[i].style.display = 'none';
    }
}

next.addEventListener("click", function (e) {
    e.preventDefault();
    n++;
    if (n > slide.length - 1) {
        n = 0;
    }
    disnon();
    slide[n].style.display = 'block';

});
prev.addEventListener("click", function (e) {
    e.preventDefault();
    n--;
    if (n < 0) {
        n = slide.length - 1;
    }
    disnon();
    slide[n].style.display = 'block';

});

setInterval(function () {
    n++;
    if (n > slide.length - 1) {
        n = 0;
    }
    disnon();
    slide[n].style.display = 'block';
}, 3000)