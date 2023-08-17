"use strict";
const Grid_Partner = "#GridPartner";
const Grid_User = "#GridUser";
const updateUserUrl = "partneradministration/updateuser";
const deleteUserUrl = "partneradministration/deleteuser"
var currentUserRowId = -1;
var currentPartnerRowId = -1;

$().ready(function () {
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
    let user = $(Grid_User).jqGrid("getRowData", rowid);
    let partner = $(Grid_Partner).jqGrid("getRowData", user?.Partner);
    $(Grid_Partner).jqGrid('resetSelection');
    //if (status) {
        $(Grid_Partner).jqGrid('setSelection', partner?.ID, true);
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

function updateUser() {
    if ($('#update_user_form').valid()) {
        let user = getFormObj(`update_user_form`);
        let data = {
            UserName: user.username,
            FirstName: user.firstName,
            LastName: user.lastName,
            Email: user.email,
            PhoneNumber: user?.phone,
            Password: user?.password,
            ConfirmPassword: user?.confirm_password,
            IsPartnerSuperAdmin: user?.gridCheck == undefined ? false : true,
            AssociationIds: currentPartnerRowId?.toString()
        };

        $.ajax({
            url: `${updateUserUrl}?userId=${currentUserRowId}`,
            contentType: "application/json",
            type: 'POST',
            async: true,
            dataType: 'json',
            data: JSON.stringify(data)
        }).done(function (result) {
            $(Grid_User).jqGrid().trigger('reloadGrid');
            if (result?.success == "true")
                showToast("User Updated");
            else
                showToast("Unsuccessful", false);
        }).fail(function (xhr) {
            showToast("Unsuccessful", false);
            console.log('error : ' + xhr.status + ' - ' + xhr.statusText + ' - ' + xhr.responseText);
        });
    }
    else
        showToast("Invalid User Details", false);
}

function onUserLoadComplete(data) {
    let id = data?.currentUserId;
    currentUserRowId = id;
    $(Grid_User).jqGrid('setSelection', id, true);
}

function onPartnerLoadComplete(data) {
    let id = data?.currentPartnerId;
    currentPartnerRowId = id;
    $(Grid_Partner).jqGrid('setSelection', id, true);
}

function deleteUser() {
    let userId = currentUserRowId;
    if (userId == -1) {
        showToast("Please Select a User to delete", false);
        return;
    }
    $.ajax({
        url: `${deleteUserUrl}?userId=${ currentUserRowId }`,
        contentType: "application/json",
        type: 'POST',
        async: true,
        dataType: 'json',
        data: ''
    }).done(function (result) {
        $(Grid_User).jqGrid().trigger('reloadGrid');
        if (result?.success == "true")
            showToast("User Deleted Successfully");
        else
            showToast("Unsuccessful", false);
    }).fail(function (xhr) {
        showToast("Unsuccessful", false);
        console.log('error : ' + xhr.status + ' - ' + xhr.statusText + ' - ' + xhr.responseText);
    });
}

function onPartnerStatusChange(selectedValue) {
    let go = $(Grid_Partner);
    $(Grid_Partner).jqGrid().setGridParam({ postData: { partnerStatusType: selectedValue } }).trigger('reloadGrid');
}