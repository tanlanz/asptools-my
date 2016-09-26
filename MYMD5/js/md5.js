function md5_load() {
    var text = $("#text_md5").val();
    if (text.toString().length < 3) {
        
    } else {
        var data = {
            text1: text
        }
        $.ajax({
            data: data,
            type: "Post",
            url: "ashx/md5.ashx",
            datatype: "html",
            success: function (data, datatype) {
                //alert(data);
                if (data != "" && data != "ERROR") {
                    $("#text_md5_show").html(data);
                }
                else alert("出现错误！");
            }
        });
    }
}