$(document).ready(function () {
    $(".addToBasket").click(function (e) {
        e.preventDefault();
        let url = $(this).attr("href");

        fetch(url).then(res => {
            if (res.ok) {
                alert("oldu");
                return res.text();
            }
            else {
                alert("olmadi");
            }
        }).then(data => {
            $(".cart-table .cart-body").html(data);
            console.log(data);
        })
    })
    $(".item-count .up").click(function (e) {
        e.preventDefault();
        count = $(this).next()
    })
})