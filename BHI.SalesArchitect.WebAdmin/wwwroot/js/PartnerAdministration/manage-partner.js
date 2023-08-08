function onUserRowSelected(rowid, status) {
    console.log(rowid, status);
    $.ajax({
        url: "/partneradministration/GetUserdata?userId=" + rowid,
        type: 'Get',
        cache: false,
        async: true,
    }).done(function (response) {
        console.log(response);
    }).fail(function (xhr) {
        console.log('error : ' + xhr.status + ' - ' + xhr.statusText + ' - ' + xhr.responseText);
    });
}