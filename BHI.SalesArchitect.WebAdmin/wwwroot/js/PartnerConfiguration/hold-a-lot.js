"use strict";
const GET_CUSTOMIZABLE_CONTENT_URL = "partnerconfiguration/getcustomizedcontent";
const UPDATE_HOLD_A_LOT_CONFIGURATION = "partnerconfiguration/saveholdalotconfiguration";

$(function () {
    setCustomizableContent();
});

async function setCustomizableContent() {
    let contentList = await executeHttpRequest(GET_CUSTOMIZABLE_CONTENT_URL, METHOD_GET);
    console.log(contentList);

    const tableBody = $("#customizableContentTable tbody");

    contentList.forEach(content => {
        const row = $("<tr>").attr("id",content.id);
        row.append($("<td>").text(content.locationDescription));
        row.append($("<td>").text(content.contentType));
        row.append($("<td>").text(content.value));

        const actionCell = $("<td>").html(`<button id=${content.id} data-bs-toggle="modal" data-bs-target="#customizedContentModal" class="btn-primary">Edit</button>`);
        row.append(actionCell);
        tableBody.append(row);
    });
}

async function updateHoldALotConfiguration() {
    let data = getFormObj("holdALotForm");
    console.log(data);

    let holdALotObj = {
        HoldAlot: data.holdALot === 'true' ? true : false,
        HoldAlotButtonText: data.holdAlotButtonText,
        BuilderPhone: data.builderPhone,
        BuilderEmail: data.builderEmail,
    }

    let result = await executeHttpRequest(UPDATE_HOLD_A_LOT_CONFIGURATION, METHOD_POST, holdALotObj);
    if (result.success == true)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);
}