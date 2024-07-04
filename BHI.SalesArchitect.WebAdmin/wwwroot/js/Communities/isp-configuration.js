const GET_COMMUNITY_LOT_STATUSES = "communities/getlotstatustabledata";
const GET_COMMUNITY_ISP_CONFIGURATION = "communities/getcommunityispconfiguration";
const DELETE_LOT_STATUS_ALLOWED = "communities/DeleteLotStatusallowed";
const DELETE_LOT_STATUS = "communities/DeleteLotStatusAssociatedWithCommunity";
const UPDATE_LOT_STATUS_NAME = "communities/updatelotstatusname";

async function setLotStatusTable(commId) {
    let url = `${GET_COMMUNITY_LOT_STATUSES}?commId=${commId}`;
    let { lotStatuses, partnerConfig } = await executeHttpRequest(url, METHOD_GET);

    console.log(lotStatuses);
    const tableBody = $("#lotStatusTable tbody");
    tableBody.empty();
    lotStatuses.forEach(status => {
        const row = $("<tr>").attr("id", status.id).attr("data-configId", status.configurationId);
        row.append($("<td>").html(`<input type="checkbox" name="activityState" ${status.activityStateId == 1 ? "checked" : ""}> <input type="color" value="${status.value}"> ${status.configuration.name}`));
        row.append($("<td>").html(`${status.configuration.partnerId != null ? '<i class="bi bi-pencil editLotStatusNameIcon" data-bs-toggle="modal" data-bs-target="#editLotStatusNameModal"></i>' : ''}`));
        row.append($("<td>").html(`<input type="checkbox" name="SuppressPrice" ${status.suppressPriceStatus ? "checked" : ""}>`).addClass("text-center"));
        if (partnerConfig.isDreamweaver)
            row.append($("<td>").html(`<input type="checkbox" name="includeDW" ${status.includeDwstatus ? "checked" : ""} ${status.activityStateId == 1 ? "" : "disabled"}>`).addClass("text-center"));
        if (partnerConfig.holdAlot) {
            row.append($("<td>").html(`<input type="checkbox" name="holdalot" ${status.holdAlotStatus ? "checked" : ""}>`).addClass("text-center"));
            row.append($("<td>").html(`<input type="text" placeholder="${partnerConfig.holdAlotButtonText ?? "Hold a Lot"}" style="display:${status.holdAlotStatus ? "block" : "none"};" value="${status.holdAlotButtonText ?? ""}">`).addClass("text-center"));
        }
        row.append($("<td>").html(`${status.configuration.partnerId != null ? '<i class="bi bi-trash3 deleteLotStatusIcon" data-bs-toggle="modal" data-bs-target="#deleteLotStatusModal"></i>' : ''}`));
        tableBody.append(row);
    });
    maketableSortable();
    addEditLotStatusNameEventListener();
    addDeleteLotStatusEventListener();
}

async function setISPConfiguration(commId) {
    let url = `${GET_COMMUNITY_ISP_CONFIGURATION}?commId=${commId}`;
    let { holdALotStatuses, ispConfiguration, pointOfInterests, community } = await executeHttpRequest(url, METHOD_GET);
    if (ispConfiguration) {
        ispConfiguration.forEach(function (item) {
            let name = item?.configuration?.code;
            let value = item.value;
            $('#commIspConfigurationForm input[type="checkbox"][name="' + name + '"]').prop('checked', value == "TRUE");
            $('#commIspConfigurationForm input[type="radio"][name="' + name + '"][value="' + value + '"]').prop('checked', true);
            $('#commIspConfigurationForm input[type="text"][name="' + name + '"]').val(value);
            $('#commIspConfigurationForm input[type="number"][name="' + name + '"]').val(value);
            $('#commIspConfigurationForm input[type="email"][name="' + name + '"]').val(value);
            $('#commIspConfigurationForm input[type="color"][name="' + name + '"]').val(value);
            $('#commIspConfigurationForm select[name="' + name + '"]').val(value);
        });
    }
    setPointOfInterests(pointOfInterests);
    $('#commIspConfigurationForm #displayName').val(community.displayName != null && community.displayName.trim() != "" ? community.displayName : community.name).prop('disabled', !community.IsOverwriteName);
    $('#commIspConfigurationForm #isOverwriteName').prop('checked', community.isOverwriteName);
    $('#commIspConfigurationForm #geospatialZoomLevel').val(community.geospatialZoomLevel);
    setHoldAlotReservationDropdown(holdALotStatuses);
}

function setPointOfInterests(pointOfInterests) {
    let checkboxContainer = $('#pointOfInterestsCheckboxContainer');
    checkboxContainer.empty();
    pointOfInterests.pointOfInterestsAll.forEach(function (item) {
        var checkbox = $('<input type="checkbox">')
            .attr('name', item.name)
            .attr('id', item.name)
            .attr('class', 'form-check-input')
            .attr('value', item.id);

        var label = $('<label>').text(item.name).attr('for', item.name).attr('class', 'form-check-label');

        checkboxContainer.append(checkbox, label, '<br>');
    });

    pointOfInterests.pointOfInterestsSelected.forEach(function (item) {
        var checkbox = $('#pointOfInterestsCheckboxContainer input[type="checkbox"][id="' + item.name + '"]');
        checkbox.prop('checked', true);
    })
}

function setHoldAlotReservationDropdown(holdALotStatuses) {
    let reservationPendingStatusDropdown = $('#reservationPendingStatusDropdown');
    let reservedStatusDropdown = $('#reservedStatusDropdown');
    reservationPendingStatusDropdown.empty();
    reservedStatusDropdown.empty();
    if (holdALotStatuses) {
        holdALotStatuses.forEach(function (status, index) {
            if (index === 0) {
                reservationPendingStatusDropdown.append($('<option>', {
                    value: 0,
                    text: "None"
                }));
                reservedStatusDropdown.append($('<option>', {
                    value: 0,
                    text: "None"
                }));
            }
            var option = $('<option>', {
                value: status.id,
                text: status.name
            });
            reservationPendingStatusDropdown.append(option);
            reservedStatusDropdown.append(option.clone());
        });
    }
}

function maketableSortable() {
    $("#lotStatusTable").sortable({
        items: 'tr:not(.drag-disabled)',
        cursor: 'all-scroll',
        axis: 'y',
        dropOnEmpty: false,
        start: function (e, ui) {
            ui.item.addClass("selected");
        },
        stop: function (e, ui) {
            ui.item.removeClass("selected");
        }
    });
}

function addEditLotStatusNameEventListener() {
    $('.editLotStatusNameIcon').on("click", function () {
        const trElement = this.closest('tr');
        const tdElement = trElement.querySelector('td');
        const lotStatusName = tdElement.textContent.trim();
        $("#editLotStatusNameModal #lotStatusName").val(lotStatusName);
        $('#editLotStatusNameModal #newLotStatusName').val('');
        $("#editLotStatusNameModal #editLotStatusNameButton").attr("data-configid", trElement.dataset.configid);
    });
}

function addDeleteLotStatusEventListener() {
    $('.deleteLotStatusIcon').on("click", async function () {
        const trElement = this.closest('tr');
        let configId = trElement.dataset.configid;
        await populateDeleteModal(configId);
        $("#deleteLotStatusModal #deleteLotStatusButton").attr("data-configid", trElement.dataset.configid);
    });
}

async function populateDeleteModal(configid) {
    let url = `${DELETE_LOT_STATUS_ALLOWED}?configId=${configid}`;
    let result = await executeHttpRequest(url, METHOD_POST);
    if (result?.success) {
        $('#deleteLotStatusModal .modal-body').html(result.message.replace(/\n/g, '<br>'));
        $('#deleteLotStatusModal #deleteLotStatusButton').show();
    }
    else {
        $('#deleteLotStatusModal .modal-body').html(result.message.replace(/\n/g, '<br>'));
        $('#deleteLotStatusModal #deleteLotStatusButton').hide();
    }
}

async function deleteLotStatus(event)
{
    console.log(event?.taeget?.dataset);
    /*const trElement = this.closest('tr');
    let configId = trElement.dataset.configid;
    let url = `${DELETE_LOT_STATUS}?configId=${configid}`;
    let result = await executeHttpRequest(url, METHOD_POST);
    if (result?.success) {
        showToast("Deleted Successfully");
    }
    else {
        showToast("Unsuccessful");
    }*/
}

function updateLotStatusName(ele) {
    const newName = $('#editLotStatusNameModal #newLotStatusName').val();
    if (newName.trim() == "") {
        showToast("Lot Status Name can't be empty", false);
        return;
    }
}