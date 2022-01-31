// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openModal(id) {
    if (id != null) {
        $('#divModal').modal('show');
        $('#spanId').text(id);
        var item = null;
        for (var i = 0; i < dataArt.length; i++) {
            item = dataArt[i];
            if (item.id == id) {
                console.log(item);
                break;
            }
        }
        $('#txtArtistName').val(item.name);
        $('#txtArtistProfile').val(item.profile);
    }
    else {
        //Thêm mới
        $('#divModal').modal('show');
        $('#spanId').text("[Thêm mới]");
        $('#txtArtistName').val("");
        $('#txtArtistProfile').val("");
    }
}

function saveArtist() {
    if ($("#spanId").text() === "[Thêm mới]") {
        //them moi
        var item = {};
        item.name = $('#txtArtistName').val();
        item.profile = $('#txtArtistProfile').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Artist?handler=Add",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { art: str },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Thêm mới thành công!");
                    window.location.reload();
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
        item.name = $('#txtArtistName').val();
        item.profile = $('#txtArtistProfile').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Artist?handler=Update",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { art: str },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Cập nhật thành công!");
                    window.location.reload();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không cập nhật được");
            }
        });
    }
}

function deleteArtist(id) {
    if (confirm("Bạn chắc chắn xóa nghệ sĩ số " + id + " không?") == true) {
        $.ajax({
            type: "POST",
            url: "/Artist?handler=Delete",
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
                    window.location.reload();
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không xóa được");
            }
        });
    }
}