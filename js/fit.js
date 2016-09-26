function edit(id, type) {//启用关闭编辑，关闭时保存修改（保存未完成）
    if (type == "1") {
        //alert("num_" + id + "");//num_tab2_1
        var tdobj1 = document.getElementById("num_" + id + "");
        var tdobj2 = document.getElementById("time_" + id + "");
        var tdobj3 = document.getElementById("id_" + id + "");
        // alert(tdobj.innerText);
        var n = tdobj1.innerText;
        var t = tdobj2.innerText;
        var i = tdobj3.innerText;

        $("#" + id + "").html("<td id=\"id_" + id + "\">" + i + "</td>"
            + " <td id=\"num_" + id + "\"><input type=\"text\" class=\"input-xlarge\" id=\"In_num_" + id + "\" value=\"" + n + "\"/></td>"
            + " <td id=\"time_" + id + "\"><input type=\"text\" class=\"input-xlarge\" id=\"In_time_" + id + "\" value=\"" + t + "\"/></td>"
            + "<td><a href=\"javascrip:void(0)\" onclick=\"edit('" + id + "',0)\" role=\"button\"><i class=\"icon-pencil\"></i></a>"
            + "<a href=\"#myModal\" role=\"button\" data-toggle=\"modal\"><i class=\"icon-remove\" onclick=\"deleId('"+ id +"')\"></i></a></td>");

    } else if (type == "0") {
        var tdobj3 = document.getElementById("id_" + id + "");
        var i = tdobj3.innerText;
        var n = document.getElementById("In_num_" + id + "").value;
        var t = document.getElementById("In_time_" + id + "").value;
        $("#" + id + "").html("<td id=\"id_" + id + "\">" + i + "</td>"
            + "<td id=\"num_" + id + "\">" + n + "</td>"
            + "<td id=\"time_" + id + "\">" + t + "</td>"
            + "<td><a href=\"javascrip:void(0)\" onclick=\"edit('" + id + "',1)\" role=\"button\"><i class=\"icon-pencil\"></i></a>"
            + "<a href=\"#myModal\" role=\"button\" data-toggle=\"modal\"><i class=\"icon-remove\" onclick=\"deleId('" + id + "')\"></i></a></td>");
    }
}
function save() {//保存修改
    window.location.href = "#profile";
}
function dele(id) {//删除一行
    alert(id);
}