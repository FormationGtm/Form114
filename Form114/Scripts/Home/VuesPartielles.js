$(function () {
    $('.img1').click(function () {
        var s = "../Produit/Details/" + $(this).find('.idProduit').html()
        window.location = s
    })

    $('.FormSubmitButton').click(function () {
        window.location = '../Regions/Index/' + $(this).find('#IdRegion').val();
        return false;
    });
})