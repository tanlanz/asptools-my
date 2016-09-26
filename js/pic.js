/*关于图片的管理
显示已有图片

删除已有图片
*/

//显示已有的图片
function pic_upload_show() {
    var data = {
        type1: 0
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/pic_show.ashx",
        datatype: "html",
        success: function (data, datatype) {
            //alert(data);
            if (data == "null") {
                $("#pic_upload").html("<img src=\"images/140x140.gif\" class=\"img-polaroid\" alt=\"null\">");
                $("#images_number").html("0");
            }
            else if (data == "error") {
                alert("ERROR");
            }
            else //$("#pic_upload").html(data);
                eval(data);
        }
    });
}

//删除已有图片
function pic_upload(id) {    
    var data = {
        type1: 2,
        pic_id: id
    }
    $.ajax({
        data: data,
        type: "Post",
        url: "../ashx/pic_show.ashx",
        datatype: "html",
        success: function (data, datatype) {
            //alert(data);
            if (data == "error") {
                alert("ERROR");
            }
            else eval(data);
        }
    });
    $("#pic_delete").click(function(){
        //alert(id);
        var data = {
            type1: 1,
            pic_id:id
        }
        $.ajax({
            data: data,
            type: "Post",
            url: "../ashx/pic_show.ashx",
            datatype: "html",
            success: function (data, datatype) {
                //alert(data);
                if (data == "error") {
                    alert("ERROR");
                }
                else window.location.href = "media.html";
            }
        });
    });
    $("#pic_change").click(function () {
        window.location.href = "#myPic";
        //alert(id);
        //var data = {
        //    type1: 3,
        //    pic_id: id
        //}
        //$.ajax({
        //    data: data,
        //    type: "Post",
        //    url: "../ashx/pic_show.ashx",
        //    datatype: "html",
        //    success: function (data, datatype) {
        //        //alert(data);
        //        if (data == "error") {
        //            alert("ERROR");
        //        }
        //        else window.location.href = "media.html";
        //    }
        //});
    });
}

//添加图片
function pic_add() {
    var f = document.getElementById("headImage").files;
    //var a = "++testsdasda";
    //alert(f[0].size);//字节
    //if (f[0].size > 5242880) {
    var formdata = new FormData();
    //}
    formdata.append("imgFile", f[0]);
    //formdata.append("all", a);
    $.ajax({
        //data: f+"&all="+a,
        type: "Post",
        data: formdata,
        cache: false,
        contentType: false,
        processData: false,
        dataType: "html",
        url: "../ashx/picload.ashx",
        success: function (data, datatype) {
            alert(data);
            window.location.href = "media.html";
        }
    });
}