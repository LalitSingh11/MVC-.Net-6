"use strict";
const GET_CUSTOMIZABLE_CONTENT_URL = "partnerconfiguration/getcustomizedcontent";
const UPDATE_HOLD_A_LOT_CONFIGURATION = "partnerconfiguration/saveholdalotconfiguration";

$(function () {
    setCustomizableContent();
    addEventListenerOnHoldAlot();
});

async function setCustomizableContent() {
    let { customizedContent, holdALot } = await executeHttpRequest(GET_CUSTOMIZABLE_CONTENT_URL, METHOD_GET);

    const tableBody = $("#customizableContentTable tbody");
    const holdALotLocationCodes = ["PopupFooter", "LeadFormHeader", "LeadFormTnC", "LeadFormFooter"];
    customizedContent.forEach(content => {
        const row = $("<tr>").attr("id",content.id);
        row.append($("<td>").text(content.locationDescription));
        row.append($("<td>").text(content.contentType));
        row.append($("<td>").text(content.value));

        const actionCell = $("<td>").html(`<button id=${content.id} data-bs-toggle="modal" data-bs-target="#customizedContentModal" class="btn-primary">Edit</button>`);
        row.append(actionCell);        

        if (!holdALotLocationCodes.includes(content.locationCode)) {
            row.addClass("hold-a-lot-content");
        }        
        tableBody.append(row);
    });
    if (!holdALot)
        hideorShowContentOnHoldALot(holdALot);
}

async function updateHoldALotConfiguration() {
    let data = getFormObj("holdALotForm");

    let holdALotObj = {
        HoldAlot: data.holdAlot == 'true' ? true : false,
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

function hideorShowContentOnHoldALot(show) {
    if (show) {
        $("#customizableContentTable").find("tr.hold-a-lot-content").show();
        $("#holdALotForm").find("div.hold-a-lot-content").show();
    }
    else {
        $("#customizableContentTable").find("tr.hold-a-lot-content").hide();
        $("#holdALotForm").find("div.hold-a-lot-content").hide();
    }
}

function addEventListenerOnHoldAlot(){
        $('#holdALotForm input[type="radio"][name="holdAlot"]').on('change', function () {
            let holdalot = $(this).val() == "true";
            hideorShowContentOnHoldALot(holdalot);
        });
}