"use strict";
const GET_LISTING_ELEVATION_IMAGES = "communities/getlistingimages";
const GET_LOT_INFO = "communities/getlotinfo";

async function populateLotInfoForm() {
    let url = `${GET_LOT_INFO}?lotId=${currentLotRowId}&commId=${currentCommRowId}`

    let lotInfo = await executeHttpRequest(url, METHOD_GET);

    $("#lotId").val(lotInfo.lotData.internalReference);
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
    let lotStatusExist = false;
    if (lotInfo?.lotState) {
        lotInfo.lotState.forEach(function (status, index) {
            if (index === 0) {
                lotStatusDropdown.append($('<option>', {
                    value: 0,
                    text: "Select Lot Status"
                }));
            }
            var option = $('<option>', {
                value: status.id,
                text: status.name
            });
            if (status.id === lotInfo.lotData.lotStateId) {
                lotStatusExist = true;
            }
            lotStatusDropdown.append(option);
        });
    }

    lotStatusDropdown.val(lotStatusExist ? lotInfo.lotData.lotStateId : 0);

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

function emptyLotInfoForm() {
    $(`#lot-edit-form`)[0].reset();
    if (ckEditorInstance) {
        ckEditorInstance.setData('');
    }
    let lotStatusDropdown = $("#lotStatus");
    lotStatusDropdown.empty();
    lotStatusDropdown.append($('<option>', {
        value: 0,
        text: "Select Lot Status"
    }));
    lotStatusDropdown.val(0);
}

function populateListingsList(lotInfo) {
    var plansTable = $("#plansTable tbody").empty();
    var specsTable = $("#specsTable tbody").empty();
    var modelsTable = $("#modelsTable tbody").empty();

    lotInfo?.plans.forEach(function (plan) {
        var row = $("<tr>").attr("id", plan.id);

        row.append($("<td>").append($("<input>").attr("type", "checkbox").attr("class", "listingCheckbox")));
        row.append($("<td>").html(plan.name + "<br>Starting From $" + plan.basePrice));
        row.append($("<td>").html(`<input type="number" placeholder="Home+Lot Price" maxlength="9">`));
        row.append($("<td>").html(`<button class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#elevationImageModal" disabled>Select Elevation Image</button>`));
        row.append($("<td>").text(plan.id));
        row.append($("<td>").text(plan.bdxid));
        row.append($("<td>").text(plan.vendorReference));
        plansTable.append(row);
    });

    lotInfo?.specs.forEach(function (spec) {
        var row = $("<tr>").attr("id", spec.id);

        row.append($("<td>").append($("<input>").attr("type", "checkbox")));
        row.append($("<td>").html(spec.name + "<br>Starting From $" + spec.basePrice));
        row.append($("<td>").text(spec.address));
        row.append($("<td>").html(`<input type="number" placeholder="Home+Lot Price" maxlength="9">`));
        row.append($("<td>").html(`<button class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#elevationImageModal" disabled>Select Elevation Image</button>`));
        row.append($("<td>").text(spec.id));
        row.append($("<td>").text(spec.bdxid));
        row.append($("<td>").text(spec.vendorReference));
        specsTable.append(row);
    });

    if (lotInfo?.models.length) {
        lotInfo?.models.forEach(function (model) {
            var row = $("<tr>").attr("id", model.id);

            row.append($("<td>").append($("<input>").attr("type", "checkbox")));
            row.append($("<td>").html(model.name + "<br>Starting From $" + model.basePrice));
            row.append($("<td>").text(model.address));
            row.append($("<td>").html(`<input type="number" placeholder="Home+Lot Price" maxlength="9">`));
            row.append($("<td>").html(`<button class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#elevationImageModal" disabled>Select Elevation Image</button>`));
            row.append($("<td>").text(model.id));
            row.append($("<td>").text(model.bdxid));
            row.append($("<td>").text(model.vendorReference));
            modelsTable.append(row);
        });
    }
    else
        $('#model-homes-tab').hide();
}

function checkLotListings(lotInfo) {
    $('#listingsTabContent tr').each(function () {
        var rowId = $(this).attr('id');
        var listing = lotInfo.listings.find(obj => obj.id.toString() === rowId);

        if (listing) {
            $(this).find('input[type="checkbox"]').prop('checked', true);
            $(this).find('input[type="number"]').val(listing.price || '');
            $(this).find('button').prop("disabled", false).attr("id", listing.listingImagesId);
        }
    });
}

function addEventListenerOnCheckboxes() {
    $('#listingsTabContent input[type="checkbox"]').on('change', function () {
        var button = $(this).closest('tr').find('button');
        button.prop('disabled', !this.checked);
    });
}
function addEventListenerOnElevationButtons() {
    $('#listingsTabContent button').on('click', function () {
        var listingId = $(this).closest("tr").attr("id");
       // populateElevationModal(listingId);
    });
}
/*
function populateElevationModal(listingId) {
    fetchElevationImages(currentLotRowId, listingId);
}
function fetchElevationImages(currentLotRowId, listingId) {
    return new Promise(function (resolve, reject) {
        $.ajax({
            url: `${GET_LOT_INFO}?lotId=${currentLotRowId}&commId=${currentCommRowId}`,
            contentType: "application/json",
            type: 'GET',
            dataType: 'json',
            success: function (result) {
                resolve(result);
            },
            error: function (xhr) {
                reject(xhr);
            }
        });
    });
}
*/