// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openKindModal(id) {
    if (id != null) {
        $('#divModal').modal('show');
        $('#spanId').text(id);
        var item = null;
        for (var i = 0; i < dataKin.length; i++) {
            item = dataKin[i];
            if (item.id == id) {
                console.log(item);
                break;
            }
        }
        $('#txtKindName').val(item.name);
    }
    else {
        //Thêm mới
        $('#divModal').modal('show');
        $('#spanId').text("[Thêm mới]");
        $('#txtKindName').val("");
    }
}

function saveKind() {
    if ($("#spanId").text() === "[Thêm mới]") {
        //them moi
        var item = {};
        item.name = $('#txtKindName').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Kind?handler=Add",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { kin: str },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Thêm mới thành công!");
                    window.location.reload();
                    //var obj = res.gen;
                    //item.id = obj.id;
                    //dataGen.push(item);
                    //$("#spanId").text(obj.id);
                    //var htmlStr = '<tr id="trGen_' + obj.id + '">';
                    //htmlStr = htmlStr + '<td>' + obj.id + '</td>';
                    //htmlStr = htmlStr + '<td>' + obj.name + '</td>';
                    //htmlStr = htmlStr + '<td><button type="button" class="btn btn-outline-primary btn-sm" onclick="openModal(' + obj.id + ');">Sửa</button>';
                    //htmlStr = htmlStr + '<button type = "button" class="btn btn-outline-danger btn-sm" onclick = "deleteGenre(' + obj.id +');" > Xóa</button ></td >';

                    //htmlStr = htmlStr + '</tr>';
                    //$("#tblGenre").append(htmlStr);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không thêm mới được!");
            }
        });
    }
    else {
        //cap nhat
        var item = {};
        item.id = parseInt($('#spanId').text());
        item.name = $('#txtKindName').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Kind?handler=Update",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { kin: str },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Cập nhật thành công!");
                    $("#trKin_" + item.id + " td:eq(1)").html(item.name);
                    for (var i = 0; i < dataKin.length; i++) {
                        var kind = dataKin[i];
                        if (kind.id == item.id) {
                            dataKin[i] = item;
                            break;
                        }
                    }
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không cập nhật được");
            }
        });
    }
}

function deleteKind(id) {
    if (confirm("Bạn chắc chắn xóa thể loại số " + id + " không?") == true) {
        $.ajax({
            type: "POST",
            url: "/Kind?handler=Delete",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { id: id },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Xóa thành công!");
                    $("#trKin_" + id).remove();
                    var i = 0;
                    for (i = 0; i < dataKin.length; i++) {
                        var kind = dataKin[i];
                        if (kind.id == item.id) {
                            break;
                        }
                    }
                    dataKin.splice(i, 1);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không xóa được");
            }
        });
    }
}