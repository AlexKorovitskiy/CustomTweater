$("#applyRegisterUserBtn").click(function (data) {
    var registerUser = {
        Login: $("#registerNameUser").val(),
        Password: $("#registerPasswordUser").val(),
        Email: $("#registerEmailUser").val(),
        Role: 'admin'
    };

    debugger;
    $.ajax({
        type: "POST",
        url: domainBackEnd + "register",
        data: JSON.stringify(registerUser),//*/$('#registerForm').serialize(),//{ user: registerUser },
        datatype: 'json',
        contentType: "application/json"
    }).success(function (data) {
        debugger;
    }).fail(function (data) {
        debugger;
    })

})