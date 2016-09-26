function load() {
    var data = {
        type: 1
    }
    ajaxload(data);
}

function adminload() {
    var data = {
        type: 0
    }
    ajaxload(data);
}
function save(id) {
    var ss = "ss" + id;
    var tt = "tt" + id;
    var s1 = $("#" + ss + "").val(); var t1 = $("#" + tt + "").val();
    if (s1 != null && s1 != "") {
        if (t1 != null && t1 != "") {
            var data = {
                type: 2,
                t2: t1,
                s2: s1,
                id: id
            }
            $.ajax({
                data: data,
                type: "Post",
                url: "../ashx/load.ashx",
                datatype: "html",
                success: function (data, datatype) {
                    if (data != null && data != "") {
                        alert("保存成功");
                        window.location.href = window.location.href;
                    }
                }
            });
        }
    }    
}
function delete1(id) {
    var data = {
        type: 3,
        id: id
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/load.ashx",
        datatype: "html",
        success: function (data, datatype) {
            if (data != null && data != "") {
                window.location.href = window.location.href;
            }
        }
    });
}
function add1() {
    var data = {
        type: 4,
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/load.ashx",
        datatype: "html",
        success: function (data, datatype) {
            if (data != null && data != "") {
                window.location.href = window.location.href;
            }
        }
    });
}

function permitShow(id) {
    var data = {
        type: 5,
        id_p:id
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/load.ashx",
        datatype: "html",
        success: function (data, datatype) {
            if (data != null && data != "") {
                alert("已设置为可见");
                window.location.href = window.location.href;
            }
        }
    });
}
function denyShow(id) {
    var data = {
        type: 6,
        id_d:id
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/load.ashx",
        datatype: "html",
        success: function (data, datatype) {
            if (data != null && data != "") {
                alert("已设置为不可见");
                window.location.href = window.location.href;
            }
        }
    });
}
function ajaxload(data) {
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/load.ashx",
        datatype: "html",
        success: function (data, datatype) {
            if (data != null && data != "") {
                $("#text").html(data);
                //document.getElementById("exit").style.display = "";
                $.ajax({
                    data: "",
                    type: "Post",
                    url: "../ashx/loginCheck.ashx",
                    datatype: "html",
                    success: function (data, datatype) {
                        //alert(data);
                         if (data == "succLogin") {
                            document.getElementById("exit").style.display = "";
                        }
                    }
                });
            }
        }
    });
}
