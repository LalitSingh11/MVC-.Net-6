"use strict";
const GRID_LOTS = "#GridLots";
const GET_LOT_INFO = "communities/getlotinfo";
var currentLotRowId = -1;
var ckEditorInstance;

$(function () {
    ClassicEditor
        .create(document.querySelector('#descriptionEditor'), {
            removePlugins: ['MediaEmbed'],
        })
        .then(editor => {
            ckEditorInstance = editor;
        })
        .catch(error => {
            console.error(error);
        });
})

function fetchLots(commId) {
    $(GRID_LOTS).jqGrid().setGridParam({ postData: { commId: commId } }).trigger('reloadGrid');
}

function onLotsGridComplete(data) {
    $(`#lot-count`).text(`Lots(${data?.total ?? 0})`);
    if (data?.total > 0) {
        let firstId = $(`${GRID_LOTS} tr`).eq(1).attr("id");
        $(GRID_LOTS).jqGrid('setSelection', firstId);
        currentLotRowId = firstId;
    }
}

function onLotSelectRow(rowId, status) {
    if (status) {
        currentLotRowId = rowId;
        populateLotInfoForm();
    }
}

async function populateLotInfoForm() {
    let url = `${GET_LOT_INFO}?lotId=${currentLotRowId}&commId=${currentCommRowId}`

    let lotInfo = await executeHttpRequest(url, METHOD_GET);

    $("#lotId").val(lotInfo.lotData.internalReference)
    $("#externalReference").val(lotInfo.lotData.externalReference);
    $("#amenityCheckbox").prop("checked", lotInfo.lotData.isAmenity);
    $("#displayName").val(lotInfo.lotData.displayName);
    $("#size").val(lotInfo.lotData.size);
    $("#premiumPrice").val(lotInfo.lotData.premiumPrice);
    $("#reservationFee").val(lotInfo.lotData.reservationFee);
    $("#block").val(lotInfo.lotData.block);
    $("#phase").val(lotInfo.lotData.phase);
    $("#elevation").val(lotInfo.lotData.elevation);
    $("#swing").val(lotInfo.lotData.swing);
    $("#description").val(lotInfo.lotData.description);
    $("#address").val(lotInfo.lotData.address);
    $("#contactUrl").val(lotInfo.lotData.contactLink);
    $("#contactButtonText").val(lotInfo.lotData.buttonText);
    $("#videoUrl").val(lotInfo.lotData.videoUrl);
    // populating lot status dropdown
    let lotStatusDropdown = $("#lotStatus");
    lotStatusDropdown.empty();
    $.each(lotInfo?.lotState, function (index, status) {
        if (index == 0) lotStatusDropdown.append($('<option>', {
            value: 0,
            text: "Select Lot Status"
        }));
        var option = $('<option>', {
            value: status.id,
            text: status.name
        });
        lotStatusDropdown.append(option);
    });
    lotStatusDropdown.val(lotInfo.lotData.lotStateId ?? 0);

    /*if (lotInfo?.lotData?.imagePath) {
        $('#hotspotImage').attr('src', lotInfo.lotData.imagePath).show();
        $('#deleteImage').show();
    }*/
    if (ckEditorInstance) {
        ckEditorInstance.setData(lotInfo.lotData.lotDescription ?? '');
    }
    populateListingsList(lotInfo);
    checkLotListings(lotInfo);
    addEventListenerOnCheckboxes();
    addEventListenerOnElevationButtons();
}
