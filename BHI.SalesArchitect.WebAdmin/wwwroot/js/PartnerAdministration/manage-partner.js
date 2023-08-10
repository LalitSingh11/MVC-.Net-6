const Grid_Partner = "#GridPartner";
const Grid_User = "#GridUser";
var currentUserRowId = -1;
var currentPartnerRowId = -1;
const updateUserUrl = "partneradministration/updateuser";
$().ready(function () {
    $("#user_form").validate({
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
                phoneUs: true
            },
            password: {
                minlength: 5
            },
            confirm_password: {
                minlength: 5,
                equalTo: "#password"
            },
        },
        // In 'messages' user have to specify message as per rules
        messages: {
            firstname: " Please enter your firstname",
            lastname: " Please enter your lastname",
            username: {
                required: " Please enter a username",
                minlength:
                    " Your username must consist of at least 2 characters"
            },
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
        $(`#user_form`)[0].reset();*/
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

function SaveUser() {
    let user = getFormObj(`user_form`);
    let data = {
            UserName: user.username,
            FirstName: user.firstName,
            LastName: user.lastName,
            Email:user.email,
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
        console.log(result);
    }).fail(function (xhr) {
        console.log('error : ' + xhr.status + ' - ' + xhr.statusText + ' - ' + xhr.responseText);
    });
}
function getFormObj(formId) {
    let formParams = {};
    $('#' + formId)
        .serializeArray()
        .forEach(function (item) {
            if (formParams[item.name]) {
                formParams[item.name] = [formParams[item.name]];
                formParams[item.name].push(item.value)
            } else {
                formParams[item.name] = item.value
            }
        });
    return formParams;
}

function onUserLoadComplete(data) {
    let id = data?.currentUserId;
    currentUserRowId = id;
    $(Grid_User).jqGrid('setSelection', id, true);
}

function OnPartnerLoadComplete(data) {
    let id = data?.currentPartnerId;
    currentPartnerRowId = id;
    $(Grid_Partner).jqGrid('setSelection', id, true);
}
