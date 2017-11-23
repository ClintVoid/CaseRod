function accButtons() {
    var acc = document.getElementsByClassName("accordion");
    var i;

    for (i = 0; i < acc.length; i++) {
        acc[i].onclick = function () {
            this.classList.toggle("active");
            var panel = this.nextElementSibling;
            if (panel.style.display === "block")
                panel.style.display = "none";
            else
                panel.style.display = "block";
        }
    }
}

// Js for marking the products
function productButton() {
    var prdct = document.getElementsByClassName("product");
    var i;

    for (i = 0; i < prdct.length; i++) {
        prdct[i].onclick = function () {
            this.classList.toggle("checked");
            if (product.style.backgroundColor === "white")
                product.style.backgroundColor = "#eee";
            else
                product.style.backgroundColor = "white";
        }
    }
}
function addItem() {

}