$(document).ready(function () {
    
    //禁止某ip访问
    var data = {
        ip: returnCitySN["cip"],
        stype:1
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/ipdeny.ashx",
        datatype: "html",
        success: function (data, datatype) {
            //alert(data);
            
            if (data == "deny") {
                window.location.href="../deny.html";
            }
            else if (data == "") {
                alert("error");
            }
        }
    });
})
function checkLogin() {
    $.ajax({
        data: "",
        type: "Post",
        url: "../ashx/loginCheck.ashx",
        datatype: "html",
        success: function (data, datatype) {
            //alert(data);
            if (data == "nologi") {
                alert("未登陆！");
                window.location.href = "../sign-in.html";
            }
        }
    });
}


function sign_out() {
    if (window.confirm('是否确定登出？')) {
        var data = {
            type1: 0
        }
        $.ajax({
            data: data,
            type: "Post",
            url: "../ashx/login.ashx",
            datatype: "html",
            success: function (data, datatype) {
                //alert(data);
                if (data == "signout") {
                    window.location.href = "../sign-in.html";
                }
            }
        });
    }
}