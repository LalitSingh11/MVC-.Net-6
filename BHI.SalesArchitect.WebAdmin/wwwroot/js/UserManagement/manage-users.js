const GRID_MANAGE_USER = "#GridManageUser";
const COMMUNITY_GRID_MANAGE_USER = "#Community_Grid_Manage_User";

function onUserRowSelected(rowid) {
    let user = $(GRID_MANAGE_USER).jqGrid("getRowData", rowid);
    console.log(user);
    populateFormAndComms(user);
}

function populateFormAndComms(user) {
    $(`#firstName`).val(user?.FirstName);
    $(`#lastName`).val(user?.LastName);
    $(`#username`).val(user?.UserName);
    $(`#email`).val(user?.Email);
    $(`#phone`).val(parseInt(user["Phone Number"]));
    if (user?.Status == "Active")
        $(`#isActiveCheck`).prop("checked", true);
    else
        $(`#isActiveCheck`).prop("checked", false);
    let a = $('input[type="radio"][name="userRole"]');
    let b = $('input[type="radio"][name="userRole"][value="' + user?.Role + '"]');
    $('input[type="radio"][name="userRole"][value="' + user?.Role + '"]').prop('checked', true);
    $(COMMUNITY_GRID_MANAGE_USER).jqGrid('resetSelection');
    commIds = user?.Communities.split(",");
    for (let id of commIds) {
        $(COMMUNITY_GRID_MANAGE_USER).jqGrid('setSelection', id, true);
    }
}

function UpdateUserRoleAndInfo() {
    let userDetails = getFormObj("user_update_form");
    let commIds = $(COMMUNITY_GRID_MANAGE_USER).getGridParam('selarrrow');

    var data = {

    }
    console.log(userDetails);

}