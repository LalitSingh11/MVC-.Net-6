const SAVE_PROSPECT_CONFIGURATION_URL = "partnerconfiguration/saveprospectconfiguration"
async function saveProspectSettings() {
    const radioButtons = $('#prospectSettingsform input[type="radio"]');
    const data = {};

    // Loop through radio buttons and add their values to the object
    radioButtons.each(function () {
        if ($(this).prop('checked')) {
            data[$(this).attr('name')] = $(this).val();
        }
    });

    const prospectObj = {
        IsIsp: data.isIsp === 'true' ? true : false,
        IsSecured: data.isSecured === 'true' ? true : false,
        ShowAllPlans: data.showAllPlans === 'true' ? true : false,
        ShowAllSpecs: data.showAllSpecs === 'true' ? true : false,
        IsHoverAllowed: data.isHoverAllowed === 'true' ? true : false,
        RequestInfoModal: data.requestInfoModal === 'true' ? true : false,
        SendLotId: data.sendLotId === 'true' ? true : false,
        LotOutlineColor: $('#outlineColor').val(),
        LotPremiumOptionalDisplay: data.lotPremiumOptionalDisplay === 'true' ? true : false,
        SuppressBuilderLogo: data.suppressBuilderLogo === 'true' ? true : false,
        SuppressBottomCommunityName: data.suppressBottomCommunityName === 'true' ? true : false,
        SuppressTopCommunityName: data.suppressTopCommunityName === 'true' ? true : false,
        DisplayLotList: data.displayLotList === 'true' ? true : false,
        DisplaySpecAddress: data.displaySpecAddress === 'true' ? true : false,
        AddModelHomesBanner: data.addModelHomesBanner === 'true' ? true : false,
        ReplaceKeyIcon: data.replaceKeyIcon === 'true' ? true : false,
        OpenSpecDefault: data.openSpecDefault === 'true' ? true : false,
        ShowExteriorColorScheme: data.showExteriorColorScheme === 'true' ? true : false,
        ShowHomesiteFilter: data.showHomesiteFilter === 'true' ? true : false,
        ShowBottombar: data.showBottombar === 'true' ? true : false
    };
    let result = await executeHttpRequest(SAVE_PROSPECT_CONFIGURATION_URL, METHOD_POST, prospectObj);
    if (result?.success)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);

}