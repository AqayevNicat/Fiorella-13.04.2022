$(document).ready(function () {
    $(".addToBasket").click(function (e) {
        e.preventDefault();
        fetch($(this).attr("href")).then(res => {
            return res.text();
        }).then(data => {
            $(".products").html(data);
        })
    })
})