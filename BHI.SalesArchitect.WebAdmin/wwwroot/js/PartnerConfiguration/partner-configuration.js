const GET_PROSPECT_CONFIGURATION = "partnerconfiguration/getprospectconfiguration"
$(function () {
    setSettingsValues();
})

async function setSettingsValues() {
    let data = await executeHttpRequest(GET_PROSPECT_CONFIGURATION, METHOD_GET);
    if (data) {
    console.log(data);
        /*populating Settings tab, isp partner type, hold a lot tab, dreamweaver tabs and pdf tab
        on the basis of name attribute of html tags */

        for (let key in data) {
            if (data.hasOwnProperty(key)) {
                let value = data[key];
                $('input[type="radio"][name="' + key + '"][value="' + value + '"]').prop('checked', true);
                $('input[type="text"][name="' + key + '"]').val(value);
                $('input[type="number"][name="' + key + '"]').val(value);
                $('input[type="email"][name="' + key + '"]').val(value);
                $('input[type="color"][name="' + key + '"]').val(value);
                $('input[type="textarea"][name="' + key + '"]').val(value);
            }
        }
    }
    //hide dwstatus grid
    let isDwClient = $('input[name="isDreamweaver"]:checked').val();
    if (isDwClient == 'false')
        $('#dreamweaver_grid').css('display', 'none');
}
