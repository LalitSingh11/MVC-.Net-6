"use strict";
const COMMUNITY_GRID_MANAGE_USER = "#Community_Grid_Manage_User";
const CREATE_NEW_USER_URL = "createuser";

$(function () {
    $("#create_new_user_form").validate({
        rules: {
            create_firstName: "required",
            create_lastName: "required",
            create_username: {
                required: true,
            },
            create_email: {
                required: true,
                email: true
            },
            create_phone: {
                minlength: 10
                //PhoneUs : true
                //pattern: `/^(1-?)?(\([2-9]\d{2}\)|[2-9]\d{2})-?[2-9]\d{2}-?\d{4}$/`
            },
            create_password: {
                minlength: 5
            },
            create_confirm_password: {
                minlength: 5,
                equalTo: "#create_password"
            },
        },
        messages: {
            create_firstName: " Please enter your firstname",
            create_lastName: " Please enter your lastname",
            create_username: {
                required: " Please enter a username",
                minlength:
                    " Your username must consist of at least 2 characters"
            },
            create_phone: "Enter a valid number",
            create_password: {
                required: " Please enter a password",
                minlength:
                    " Your password must be consist of at least 5 characters"
            },
            create_confirm_password: {
                required: " Please enter a password",
                minlength:
                    " Your password must be consist of at least 5 characters",
                equalTo: " Please enter the same password as above"
            },
        }
    });
});

async function createNewUser() {
    if ($('#create_new_user_form').valid()) {
        showLoader();
        let user = getFormObj("create_new_user_form");
        console.log(user);
        let commIds = $(COMMUNITY_GRID_MANAGE_USER).getGridParam('selarrrow');

        var data = {
            UserName: user.create_username,
            FirstName: user.create_firstName,
            LastName: user.create_lastName,
            Email: user.create_email,
            PhoneNumber: user?.create_phone,
            Password: user?.create_password,
            ConfirmPassword: user?.create_confirm_password,
            AssociationIds: commIds.toString(),
            RoleId: parseInt(user?.userRole)
        }
        console.log(user);
        let result = await executeHttpRequest(CREATE_NEW_USER_URL, METHOD_POST, data);
        if (result?.success) {
            hideLoader();
            window.location.href = "Index";
            showToast("User Created Successfully");
        }
        else
            showToast("Unsuccessful", false);
        hideLoader();
    }
    else
        showToast("Invalid User Details", false);
}