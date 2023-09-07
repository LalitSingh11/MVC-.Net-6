"use strict";
const GET_COMMUNITY_POPUPTITLES = "communities/getcommunitypoptitles";
const UPDATE_COMMUNITY_POPUPTITLES = "communities/savecommunitypopuptitles";

$(function () {
    setCommunityTitles();
});

async function setCommunityTitles() {
    let url = `${GET_COMMUNITY_POPUPTITLES}?commId=${currentCommRowId}`;
    let popUpData = await executeHttpRequest(url, METHOD_GET);
    popUpData.forEach(function (item) {
        let inputName = item.code;
        let inputValue = item.configValue;
        $('#commTitleSettingsForm input[name="' + inputName + '"]').val(inputValue);
    });
    console.log(popUpData);
}