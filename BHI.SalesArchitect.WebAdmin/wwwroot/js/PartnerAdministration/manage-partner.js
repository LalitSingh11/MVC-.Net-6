"use strict";
const GRID_PARTNER = "#GridPartner";
const GRID_USER = "#GridUser";
const UPDATE_USER_URL = "partneradministration/updateuser";
const DELETE_USER_URL = "partneradministration/deleteuser"
var currentUserRowId = -1;
var currentPartnerRowId = -1;

$(function () {
    $("#update_user_form").validate({
        rules: {
            firstName: "required",
            lastName: "required",
            username: {
                required: true,
            },
            email: {
                required: true,
                email: true
            },
            phone: {
                minlength:10
                //PhoneUs : true
                //pattern: `/^(1-?)?(\([2-9]\d{2}\)|[2-9]\d{2})-?[2-9]\d{2}-?\d{4}$/`
            },
            password: {
                minlength: 5
            },
            confirm_password: {
                minlength: 5,
                equalTo: "#password"
            },
        },
        messages: {
            firstname: " Please enter your firstname",
            lastname: " Please enter your lastname",
            username: {
                required: " Please enter a username",
                minlength:
                    " Your username must consist of at least 2 characters"
            },
            phone: "Enter a valid number",
            password: {
                required: " Please enter a password",
                minlength:
                    " Your password must be consist of at least 5 characters"
            },
            confirm_password: {
                required: " Please enter a password",
                minlength:
                    " Your password must be consist of at least 5 characters",
                equalTo: " Please enter the same password as above"
            },
        }
    });
});

function onUserRowSelected(rowid, status) {
    currentUserRowId = rowid;
    let user = $(GRID_USER).jqGrid("getRowData", rowid);
    let partner = $(GRID_PARTNER).jqGrid("getRowData", user?.Partner);
    $(GRID_PARTNER).jqGrid('resetSelection');
    //if (status) {
    $(GRID_PARTNER).jqGrid('setSelection', partner?.ID, true);
        populateUserForm(user);
    /*}
    else
        $(`#update_user_form`)[0].reset();*/
}

function onPartnerRowSelected(rowid, status) {
    currentPartnerRowId = rowid;
}
function populateUserForm(user) {
    $(`#firstName`).val(user?.FirstName);
    $(`#lastName`).val(user?.LastName);
    $(`#username`).val(user?.UserName);
    $(`#email`).val(user?.Email);
    $(`#phone`).val(parseInt(user["Phone Number"]));
    if(user?.Role == "false")
        $(`#gridCheck`).prop("checked", false);
    else 
        $(`#gridCheck`).prop("checked", true);
}

async function updateUser() {
    if ($('#update_user_form').valid()) {
        showLoader();
        let user = getFormObj(`update_user_form`);
        let data = {
            UserName: user.username,
            FirstName: user.firstName,
            LastName: user.lastName,
            Email: user.email,
            PhoneNumber: user?.phone,
            Password: user?.password,
            ConfirmPassword: user?.confirm_password,
            IsPartnerSuperAdmin: user?.partnerSuperAdminCheck == undefined ? false : true,
            AssociationIds: currentPartnerRowId?.toString()
        };

        let url = `${UPDATE_USER_URL}?userId=${currentUserRowId}`;
        let result = await executeHttpRequest(url, METHOD_POST, data);
        $(GRID_USER).jqGrid().trigger('reloadGrid');
        if (result?.success)
            showToast("User Updated");
        else
            showToast("Unsuccessful", false);
        hideLoader();
    }
    else
        showToast("Invalid User Details", false);
}

function onUserLoadComplete(data) {
    let id = data?.currentUserId;
    currentUserRowId = id;
    $(GRID_USER).jqGrid('setSelection', id, true);
}

function onPartnerLoadComplete(data) {
    let id = data?.currentPartnerId;
    currentPartnerRowId = id;
    $(GRID_PARTNER).jqGrid('setSelection', id, true);
}

async function deleteUser() {
    let userId = currentUserRowId;
    if (userId == -1) {
        showToast("Please Select a User to delete", false);
        return;
    }

    let url = `${DELETE_USER_URL}?userId=${currentUserRowId}`;
    let result = await executeHttpRequest(url, METHOD_POST);
    $(GRID_USER).jqGrid().trigger('reloadGrid');
    if (result?.success)
        showToast("User Deleted Successfully");
    else
        showToast("Unsuccessful", false);

}

function onPartnerStatusChange(selectedValue) {
    let go = $(GRID_PARTNER);
    $(GRID_PARTNER).jqGrid().setGridParam({ postData: { partnerStatusType: selectedValue } }).trigger('reloadGrid');
}