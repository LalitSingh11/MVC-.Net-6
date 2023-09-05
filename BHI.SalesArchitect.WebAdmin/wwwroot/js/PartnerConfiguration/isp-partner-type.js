const UPDATE_ISP_PARTNER_CONFIGURATION = "partnerconfiguration/saveisppartnerconfiguration";

async function updateIspPartnerTypeConfiguration() {
    let data = getFormObj("ispPartnerTypeForm");
    let ispPartnerObj = {
        GoogleApikey: data.googleApikey,
        GoogleClientId: data.googleClientId,
        NhtbuilderNumber: data.nhtbuilderNumber,
        IspPartnerType: parseInt(data.ispPartnerType),
        PreviewIspplugin: data.previewIspplugin === 'true' ? true : false
    }

    let result = await executeHttpRequest(UPDATE_ISP_PARTNER_CONFIGURATION, METHOD_POST, ispPartnerObj);
    if (result.success == true)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);
}