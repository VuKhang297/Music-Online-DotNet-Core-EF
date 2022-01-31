// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openModal(id) {
    if (id != null) {
        $('#divModal').modal('show');
        $('#spanId').text(id);
        var item = null;
        for (var i = 0; i < dataGen.length; i++) {
            item = dataGen[i];
            if (item.id == id) {
                console.log(item);
                break;
            }
        }
        $('#txtGenreName').val(item.name);
    }
    else {
        //Thêm mới
        $('#divModal').modal('show');
        $('#spanId').text("[Thêm mới]");
        $('#txtGenreName').val("");
    }
}

function saveGenre() {
    if ($("#spanId").text() === "[Thêm mới]") {
        //them moi
        var item = {};
        item.name = $('#txtGenreName').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Genre?handler=Add",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { gen: str },
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
        item.name = $('#txtGenreName').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Genre?handler=Update",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { gen: str },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Cập nhật thành công!");
                    $("#trGen_" + item.id + " td:eq(1)").html(item.name);
                    for (var i = 0; i < dataGen.length; i++) {
                        var genre = dataGen[i];
                        if (genre.id == item.id) {
                            dataGen[i] = item;
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

function deleteGenre(id) {
    if (confirm("Bạn chắc chắn xóa chủ đề số " + id + " không?") == true) {
        $.ajax({
            type: "POST",
            url: "/Genre?handler=Delete",
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
                    $("#trGen_" + id).remove();
                    var i = 0;
                    for (i = 0; i < dataGen.length; i++) {
                        var genre = dataGen[i];
                        if (genre.id == item.id) {
                            break;
                        }
                    }
                    dataGen.splice(i, 1);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không xóa được");
            }
        });
    }
}