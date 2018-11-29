$("#submitLogin").click(function () {
    var loginObject = {
        username: $("#loginName").val(),
        password: $("#loginPassword").val()
    }
    $.ajax({
        type: 'POST',
        url: domainBackEnd + 'token',
        data: loginObject
    }).success(function (data) {
        sessionStorage.setItem(tokenKey, data.access_token);
        window.location.href = "home/index"
    }).fail(function (data) {
        debugger;
        console.log(data);
    });
})