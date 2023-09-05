"use strict";
const GET_POPUPTITLES_CONFIGURATION = "partnerconfiguration/getpoptitlesconfiguration";
const UPDATE_POPUPTITLES_CONFIGURATION = "partnerconfiguration/savepopuptitlesconfiguration";

$(function () {
    setTitleSettings();
});

async function setTitleSettings() {
    let popUpData = await executeHttpRequest(GET_POPUPTITLES_CONFIGURATION, METHOD_GET);
    popUpData.forEach(function (item) {
        let inputName = item.code; 
        let inputValue = item.configValue;
        $('#popupTitleSettingsForm input[name="' + inputName + '"]').val(inputValue);
    });
    console.log(popUpData);
}

async function updateTitleSettings() {
    let popupTitlesObj = getFormObj("popupTitleSettingsForm");

    let result = await executeHttpRequest(UPDATE_POPUPTITLES_CONFIGURATION, METHOD_POST, popupTitlesObj);
    if (result.success == true)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);
}