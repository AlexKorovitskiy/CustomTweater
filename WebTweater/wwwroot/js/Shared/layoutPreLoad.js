
var tokenKey = "accessToken";
var domainBackEnd = "https://localhost:44341/";
var domainFronEnd = "https://localhost:44332";
$(document).ajaxSend(function (event, xhr) {
    var token = sessionStorage.getItem(tokenKey);
    xhr.setRequestHeader("Authorization", "Bearer " + token);
});

$(document).ajaxError(function (event, xhr) {
    if (xhr.status == 401) {
        window.location.href = domainFronEnd;
    }
});