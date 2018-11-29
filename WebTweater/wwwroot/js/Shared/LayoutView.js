
$("#logoutBtn").click(function (data) {
    sessionStorage.removeItem(tokenKey);
    window.location.href = domainFronEnd;
});

$("#registrationBtn").click(function (data) {
    var url = domainFronEnd + "/Account/RegistrationUser";
    $(location).attr('href', url);
});