"use strict";
const GET_COMMUNITY_POPUPTITLES = "communities/getcommunitypopuptitles";
const UPDATE_COMMUNITY_POPUPTITLES = "communities/updatecommpopuptitles";
const GET_COMMUNITY_CUSTOMIZABLE_CONTENT = "communities/getcommunitycustomizablecontent";

async function setCommunityTitles(commId) {
    let url = `${GET_COMMUNITY_POPUPTITLES}?commId=${commId}`;
    let popupTitlesData = await executeHttpRequest(url, METHOD_GET);
    popupTitlesData.forEach(function (item) {
        let inputName = item.configuration.code;
        let inputValue = item.value;
        $('#commTitleSettingsForm input[name="' + inputName + '"]').val(inputValue);
    });
}
async function setCommunityCustomizableContent(commId) {
    let url = `${GET_COMMUNITY_CUSTOMIZABLE_CONTENT}?commId=${commId}`;
    let { customizedContent, holdALot } = await executeHttpRequest(url, METHOD_GET);

    const tableBody = $("#communityCustomizableContentTable tbody");
    const holdALotLocationCodes = ["PopupFooter", "LeadFormHeader", "LeadFormTnC", "LeadFormFooter"];

    customizedContent.forEach(content => {
        const row = $("<tr>").attr("id", content.id);
        row.append($("<td>").text(content.locationDescription));
        row.append($("<td>").text(content.contentType));
        row.append($("<td>").text(content.value));

        const actionCell = $("<td>").html(`<button id=${content.id} data-bs-toggle="modal" data-bs-target="#communityCustomizedContentModal" class="btn-primary">Edit</button>`);
        row.append(actionCell);
        if (!holdALotLocationCodes.includes(content.locationCode)) {
            row.addClass("hold-a-lot-content");
        } 
        tableBody.append(row);
    });
    if (!holdALot)
        hideorShowContentOnHoldALot(holdALot);
}

async function updateCommunityTitles() {
    let popupTitlesObj = getFormObj("commTitleSettingsForm");
    console.log(popupTitlesObj);
    let url = `${UPDATE_COMMUNITY_POPUPTITLES}?communityId=${currentCommRowId}`;
    let result = await executeHttpRequest(url, METHOD_POST, popupTitlesObj);
    if (result.success == true)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);
}

function hideorShowContentOnHoldALot(show) {
    if (show) {
        $("#communityCustomizableContentTable").find("tr.hold-a-lot-content").show();
    }
    else {
        $("#communityCustomizableContentTable").find("tr.hold-a-lot-content").hide();
    }
}