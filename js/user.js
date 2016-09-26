function retu() {
    $.ajax({
        data: "",
        type: "Post",
        url: "../ashx/loginCheck.ashx",
        datatype: "html",
        success: function (data, datatype) {
            //alert(data);
            if (data == "") {
                alert("已登陆");
                window.history.back(-1);
            }
        }
    });
}
function signIn() {
    //alert(returnCitySN["cip"] + ',' + returnCitySN["cname"]);//获得当前网页的ip 搜狐接口
    var data = {
        ip: returnCitySN["cip"],
        stype: 0
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/ipdeny.ashx",//null
        datatype: "html",
        success: function (data, datatype) {
            //alert(data);
            if (data == "deny") {
                window.opener = null;//关闭当前网站
                window.open('', '_self');
                window.close();
            }
        }
    });
    
    
    //ip禁止未完成
}

function Test() {
    var text1 = $("#name").val();
    var text2 = $("#password").val();
    if (text1 == null || text2 == null) {
        alert("error");
    }
    else if (text1.toString().length < 3 && text1.toString().length>15) {
        alert("文本不符合要求");
    } else if (text2.toString().length < 3 && text2.toString().length>15) {
        alert("文本不符合要求");
    } else {
        var data = {
            uname: text1,
            pwd: text2,
            type1:1
        }
        $.ajax({
            data: data,
            type: "Post",
            url: "../ashx/login.ashx",
            datatype: "html",
            success: function (data, datatype) {
                //alert(data);
                if (data == "succ1") {
                    alert("登陆成功");
                    window.location.href = "../index.html";
                }else if (data == "succ2") {
                    alert("登陆成功");
                    window.location.href="../Badmin/index.html";
                }                
                else {
                    alert(data);
                    //window.location.href="sign-in.html";
                }
            }
        });
    }
}
function sign_up() {
    var name = $("#name").val();
    var password = $("#password").val();
    var re_password = $("#re_password").val();
    var username = $("#username").val();
    if (name == null || password == null || username == null || re_password == null) {
        alert("请输入全部项");
    }
    else if (name.toString().length < 3 || name.toString().length > 15) {
        alert("文本不符合要求");
    }
    else if (username.toString().length < 3 || username.toString().length > 15) {
        alert("文本不符合要求");
    }
    else if (password != re_password) {
        alert("密码前后不一致");
    }
    else if (document.getElementById("ckb").checked) {
        var data = {
            uname: name,
            username: username,
            pwd: password,
            ip2:returnCitySN["cip"],
            type1: 1
        }
        $.ajax({
            data: data,
            type: "Post",
            url: "../ashx/register.ashx",
            datatype: "html",
            success: function (data, datatype) {
                //alert(data);
                if (data == "succ") {
                    alert("注册成功");
                    window.location.href = "../sign_in.html";
                }
                else {
                    alert(data);
                    //window.location.href="sign-in.html";
                }
            }
        });
    }
    else alert("请同意条款！");
}

