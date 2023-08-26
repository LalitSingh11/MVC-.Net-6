"use strict";

const METHOD_GET = "GET";
const METHOD_POST = "POST";

async function executeHttpRequest(uri, method, body) {
    const options = {
        method: method,
        headers: {
            'Content-Type': 'application/json',
        },
    };

    if (body)
        options.body = JSON.stringify(body);

    try {
        const response = await fetch(uri, options);
        const responseData = await response?.json();
        return responseData;
    } catch (error) {
        showToast("Something went wrong!", false);
        console.warn(error);
    }
}

function showToast(message = "", success = true, delayInMilliseconds = 3000) {
    const toast = document.getElementById('myToast');
    const toastBody = toast.querySelector('.toast-body');
    const toastHeader = toast.querySelector('.toast-header');
    const toastHeaderStrong = toast.querySelector('.mr-auto');

    toastBody.innerHTML = `<b>${message}</b>`;
    toastHeaderStrong.innerHTML = success ? "Success" : "Error";

    if (success) {
        toastHeader.classList.remove('bg-danger');
        toastHeader.classList.add('bg-success');
    } else {
        toastHeader.classList.remove('bg-success');
        toastHeader.classList.add('bg-danger');
    }

    const bsToast = new bootstrap.Toast(toast);
    bsToast.show();

    setTimeout(function () {
        bsToast.hide();
    }, delayInMilliseconds);
}

function getFormObj(formId) {
    let formParams = {};
    const form = document.getElementById(formId);
    const formElements = form.elements;

    for (const item of formElements) {
        if (item.name) {
            if (item.type == "checkbox")
                formParams[item.name] = item.checked;
            else
                formParams[item.name] = item.value;
        }
    }
    return formParams;
}

function showLoader() {
    document.getElementById("universal-loader").style.display = "block";
    document.getElementById("overlay").style.display = "block";
}

function hideLoader() {
    document.getElementById("universal-loader").style.display = "none";
    document.getElementById("overlay").style.display = "none";
}

