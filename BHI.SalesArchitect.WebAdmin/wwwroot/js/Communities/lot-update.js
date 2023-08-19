
$(document).ready(function () {
    $('#imageInput').change(function () {
        var fileName = $(this).val().split('\\').pop();
        $(this).attr('data-content', fileName !== "" ? fileName : "Hot Spot Image");
    });
});