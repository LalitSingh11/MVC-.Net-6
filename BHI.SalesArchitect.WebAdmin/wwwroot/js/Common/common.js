"use strict";

function showToast(message = "", success = true, delayInMilliseconds = 3000) {
    const toast = $('#myToast');
    const toastBody = toast.find('.toast-body');
    const toastHeader = toast.find('.toast-header');
    const toastHeaderStrong = toast.find('.mr-auto');

    toastBody.html(`<b>${message}<b>`);
    toastHeaderStrong.html(success ? "<b>Success</b>" : "<b>Error</b>");

    if (success)
        toastHeader.removeClass('bg-danger').addClass('bg-success');
    else 
        toastHeader.removeClass('bg-success').addClass('bg-danger');

    toast.toast('show');
    setTimeout(function () {
        toast.toast('hide');
    }, delayInMilliseconds);
}

function getFormObj(formId) {
    let formParams = {};
    $('#' + formId)
        .serializeArray()
        .forEach(function (item) {
            if (formParams[item.name]) {
                formParams[item.name] = [formParams[item.name]];
                formParams[item.name].push(item.value)
            } else {
                formParams[item.name] = item.value
            }
        });
    return formParams;
}


