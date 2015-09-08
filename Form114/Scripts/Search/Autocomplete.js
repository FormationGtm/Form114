$(function () {
    var availableTags = [""];
    $.getJSON("/Search/ListeVille3", function (data) {
        $.each(data, function (idx, item) {

            var obj = { id: item.id, name: item.name }
            availableTags.push(obj);
        });
    });
    var $input = $('#typeahead');
    $input.typeahead({
        source: availableTags,
        autoSelect: true
    })
    $input.change(function () {
        var current = $input.typeahead("getActive");
        if (current) {
            // Some item from your model is active!
            if (current.name == $input.val()) {
                $("#Ville").val(parseInt(current.id));
                // This means the exact match is found. Use toLowerCase() if you want case insensitive match.
            } else {
                // This means it is only a partial match, you can either add a new item
                // or take the active if you don't want new items
            }
        } else {
            // Nothing is active so it is a new value (or maybe empty value)
        }
    });
});