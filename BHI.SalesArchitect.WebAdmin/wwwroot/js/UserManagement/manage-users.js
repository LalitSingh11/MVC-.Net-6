"use strict";
const GRID_MANAGE_USER = "#GridManageUser";
const COMMUNITY_GRID_MANAGE_USER = "#Community_Grid_Manage_User";
const UPDATE_USER_URL = "usermanagement/updateuser";
const DELETE_USER_URL = "usermanagement/deleteuser";
var currentUserRowId = -1;

$(function () {
    $("#user_update_form").validate({
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
                minlength: 10
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

function onUserRowSelected(rowid) {
    let user = $(GRID_MANAGE_USER).jqGrid("getRowData", rowid);
    currentUserRowId = rowid; 
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
    let commIds = user?.Communities.split(",");
    for (let id of commIds) {
        $(COMMUNITY_GRID_MANAGE_USER).jqGrid('setSelection', id, true);
    }
}

async function UpdateUserRoleAndInfo() {
    if (currentUserRowId == -1) {
        showToast("Please select a user", false);
        return;
    }
    if ($('#user_update_form').valid()) {
        showLoader();
        let user = getFormObj("user_update_form");
        let commIds = $(COMMUNITY_GRID_MANAGE_USER).getGridParam('selarrrow');

        var data = {
            UserName: user.username,
            FirstName: user.firstName,
            LastName: user.lastName,
            Email: user.email,
            PhoneNumber: user?.phone,
            Password: user?.password,
            ConfirmPassword: user?.confirm_password,
            AssociationIds: commIds.toString(),
            IsActive: user?.isActiveCheck,
            RoleId: parseInt(user?.userRole)
        }
    
        let url = `${UPDATE_USER_URL}?userId=${currentUserRowId}`;
        let result = await executeHttpRequest(url, METHOD_POST, data);
        $(GRID_MANAGE_USER).jqGrid().trigger('reloadGrid');
        if (result?.success)
            showToast("User Updated");
        else
            showToast("Unsuccessful", false);
        hideLoader();
    }
    else
        showToast("Invalid User Details", false);
}

function onManageUserComplete() {
    if (currentUserRowId == -1) {
        var firstId = $(`${GRID_MANAGE_USER} tr`).eq(1).attr("id");
        if (firstId != undefined) {
            $(GRID_MANAGE_USER).jqGrid('setSelection', firstId);
            currentUserRowId = firstId;
        }
    }
    else {
        $(GRID_MANAGE_USER).jqGrid('setSelection', currentUserRowId);
    }
}

async function deleteUser() {
    let userId = currentUserRowId;
    if (userId == -1) {
        showToast("Please Select a User to delete", false);
        return;
    }

    let url = `${DELETE_USER_URL}?userId=${currentUserRowId}`;
    let result = await executeHttpRequest(url, METHOD_POST);
    $(GRID_MANAGE_USER).jqGrid().trigger('reloadGrid');
    if (result?.success) {
        showToast("User Deleted Successfully");
        $(`#user_update_form`)[0].reset();
    }
    else
        showToast("Unsuccessful", false);
}