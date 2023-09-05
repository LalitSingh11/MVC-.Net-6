"use strict";
const LOT_UPDATE_URL = "communities/updatelot";
async function updateUser() {
    if (currentLotRowId == -1) {
        showToast("Select a lot", false);
        return;
    }
    
    let lot = getFormObj("lot-edit-form");
    let lotData = {
        Id: currentLotRowId,
        LotStateId: lot.lotStatus,
        Size: lot?.size.trim(),
        Block: lot?.block.trim(),
        Phase: lot?.phase.trim(),
        Description: lot?.description.trim(),
        Address: lot?.address.trim(),
        Elevation: lot?.elevation.trim(),
        Swing: lot?.swing.trim(),
        PremiumPrice: lot?.premiumPrice.trim() == '' ? null : lot?.premiumPrice.trim(),
        ExternalReference: lot?.externalReference?.trim(),
        ContactLink: lot?.contactUrl.trim(),
        ButtonText: lot?.contactButtonText.trim(),
        IsAmenity: lot.amenityCheckbox == "on" ? true : false,
        DisplayName: lot?.displayName.trim(),
        VideoUrl: lot?.videoUrl.trim(),
        ReservationFee: lot?.reservationFee.trim() == '' ? null : lot?.reservationFee.trim()
        //ImagePath
    }

    if (lot.lotStatus == "0") {
        showToast("Select a Lot Status", false);
        return;
    }

    //get checked listings
    let lotListing = [];
    $('#listingsTabContent tr').each(function () {
        var checkbox = $(this).find('input[type="checkbox"]');
        var isChecked = checkbox.prop('checked');

        if (isChecked) {
            var trId = $(this).attr('id');
            var price = $(this).find('input[type="number"]').val();
            var rowData = {
                LotId: currentLotRowId,
                ListingId: trId,
                Price: price?.trim() == '' ? null : price?.trim()
            };
            lotListing.push(rowData);
        }
    });
    
    if (ckEditorInstance)
        lotData.LotDescription = ckEditorInstance.getData();
    /* console.log(data);
     var lotImage = $('#lotImageFile').val();
     //var lotImageFile = lotImage.val();
     console.log(lotImage);
     console.log(lotImageFile);*/

    let result = await executeHttpRequest(LOT_UPDATE_URL, METHOD_POST, { lot: lotData, lotListing: lotListing });
    if (result?.success)
        showToast("Lot Updated");
    else
        showToast("Unsuccesful", false);
}
