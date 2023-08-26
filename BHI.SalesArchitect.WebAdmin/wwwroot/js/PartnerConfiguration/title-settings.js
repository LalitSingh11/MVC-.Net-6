const GET_POPUPTITLES_CONFIGURATION = "partnerconfiguration/getpoptitlesconfiguration"
const UPDATE_POPUPTITLES_CONFIGURATION = "partnerconfiguration/savepopuptitlesconfiguration"
$(function () {
    setTitleSettings();
});

async function setTitleSettings() {
    let popUpData = await executeHttpRequest(GET_POPUPTITLES_CONFIGURATION, METHOD_GET);
    popUpData.forEach(function (item) {
        var inputName = item.code; 
        var inputValue = item.configValue;
        $('#popupTitleSettingsForm input[name="' + inputName + '"]').val(inputValue);
    });
    console.log(popUpData);
}

async function updateTitleSettings() {
    const popupTitlesObj = {};

    $("#popupTitleSettingsForm input[type='text']").each(function () {
        popupTitlesObj[$(this).attr("name")] = $(this).val();
    });

    console.log(popupTitlesObj);

    let result = await executeHttpRequest(UPDATE_POPUPTITLES_CONFIGURATION, METHOD_POST, popupTitlesObj);
    if (result.success == true)
        showToast("Titles Updated Successfully");
    else
        showToast("Unsuccessful");
}