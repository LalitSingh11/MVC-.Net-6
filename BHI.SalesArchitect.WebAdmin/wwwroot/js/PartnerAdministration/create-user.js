
"use strict";
var currentRowId = -1;
const CREATE_USER_URL = "adduser";
$().ready(function () {
    $("#create_user_form").validate({
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
                minlength: 10,
                //phoneUs: true
            },
            create_password: {
                required:true,
                minlength: 5
            },
            create_confirm_password: {
                required: true,
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
            create_phone:  "Please enter correct phone number",
            create_password: {
                required: " Please enter a password",
                minlength:
                    " Your password must be consist of at least 5 characters"
            },
            create_confirm_password: {
                required: " Please enter a password",
                minlength:
                    " Your password must be consist of at least 5 characters",
                equalTo: " Please enter the same password as before"
            },
        }
    });
});

function onPartnerUserRowSelected(rowid) {
    currentRowId = rowid;
}

function createUser() {
    if (currentRowId == -1) {
        showToast("Please select a partner for User", false);
        return;
    }
    var isvalid = $('#create_user_form').valid();
    if (isvalid) {
        let user = getFormObj(`create_user_form`);
        let data = {
            UserName: user.create_username,
            FirstName: user.create_firstName,
            LastName: user.create_lastName,
            Email: user.create_email,
            PhoneNumber: user?.create_phone,
            Password: user?.create_password,
            ConfirmPassword: user?.create_confirm_password,
            IsPartnerSuperAdmin: user?.create_roleCheck == undefined ? false : true,
            AssociationIds: currentRowId?.toString()
        };        

        $.ajax({
            url: CREATE_USER_URL,
            contentType: "application/json",
            type: 'POST',
            dataType: 'json',
            data: JSON.stringify(data)
        }).done(function (result) {
            if (result?.success == "true")
                showToast("User Created");
            else
                showToast(data?.message, false);
        }).fail(function (xhr) {
            showToast("Unsuccessful", false);
            console.log('error : ' + xhr.status + ' - ' + xhr.statusText + ' - ' + xhr.responseText);
        });
    }
    else
        showToast("Invalid Details", false);
}
