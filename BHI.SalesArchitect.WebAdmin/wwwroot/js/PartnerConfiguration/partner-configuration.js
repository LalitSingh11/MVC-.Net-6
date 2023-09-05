"use strict";
const GET_PROSPECT_CONFIGURATION = "partnerconfiguration/getprospectconfiguration";

$(function () {
    setSettingsValues();
})

async function setSettingsValues() {
    let data = await executeHttpRequest(GET_PROSPECT_CONFIGURATION, METHOD_GET);
    if (data) {
    console.log(data);
        /*populating Settings tab, isp partner type, hold a lot tab and dreamweaver tab
        on the basis of name attribute of html tags */

        for (let key in data) {
            if (data.hasOwnProperty(key)) {
                let value = data[key];
                if(isValidSelector(value))
                    $('input[type="radio"][name="' + key + '"][value="' + value + '"]').prop('checked', true);
                $('input[type="text"][name="' + key + '"]').val(value);
                $('input[type="number"][name="' + key + '"]').val(value);
                $('input[type="email"][name="' + key + '"]').val(value);
                $('input[type="color"][name="' + key + '"]').val(value);
            }
        }
        //pdf settings tab
        $("#pdfDisclaimer").val(data.holdAlotDisclaimer);
    }
    //hide dwstatus grid
    let isDwClient = $('input[name="isDreamweaver"]:checked').val();
    if (isDwClient == 'false')
        $('#dreamweaver_grid').css('display', 'none');
}

function isValidSelector(selector) {
    if (typeof selector === 'string') {
        var regex = /[!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?]+/;
        return !regex.test(selector);
    }
    return true;
}