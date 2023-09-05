const UPDATE_PDF_CONFIGURATION = "partnerconfiguration/savepdfconfiguration";

async function updatePdfConfiguration() {
    let data = getFormObj("pdfDisclaimerForm");
    console.log(data);
    let pdfSettingsObj = {
        HoldAlotDisclaimer: data.holdAlotDisclaimer
    }

    let result = await executeHttpRequest(UPDATE_PDF_CONFIGURATION, METHOD_POST, pdfSettingsObj);
    if (result.success == true)
        showToast("Configuration Updated Successfully");
    else
        showToast("Unsuccessful", false);
}