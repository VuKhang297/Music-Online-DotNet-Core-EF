// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var songId = 0;
function openModal(id) {
    if (id != null) {
        $('#divLyricModal').modal('show');
        $('#spanId').text(id);
        var item = null;
        for (var i = 0; i < dataSong.length; i++) {
            item = dataSong[i];
            if (item.id == id) {
                console.log(item);
                break;
            }
        }
        $('#txtSongLyric').val(item.name);
    }
    else {
        //Thêm mới
        $('#divModal').modal('show');
        $('#spanId').text("[Thêm mới]");
        $('#txtSongLyric').val("");
    }
}
function openLyricModal(id) {
    songId = id;
    $('#lyricModal').modal('show');
    $('#spanSongId').text(id);
    var item = null;
    for (var i = 0; i < dataSong.length; i++) {
        item = dataSong[i];
        if (item.id == id) {
            console.log(item);
            break;
        }
    }
    $('#txtSongLyric').val(item.lyric);
}
function saveSong(id) {
    if ($("#spanId").text() === "[Thêm mới]") {
        //them moi
        var item = {};
        item.lyric = $('#txtLyric').val();
        item.name = $('#txtName').val();
        item.singer = $('#txtSinger').val();
        item.composed = $('#txtComposed').val();
        item.album = $('#txtAlbum').val();
        item.link = $('#inputFile').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Song?handler=Add",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { song: str },
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
        item.id = songId;
        item.lyric = $('#txtSongLyric').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Song?handler=Update",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { song: str },
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

function deleteSong(id) {
    if (confirm("Bạn chắc chắn xóa bài hát số " + id + " không?") == true) {
        $.ajax({
            type: "POST",
            url: "/Song?handler=Delete",
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


function goPrev() {
    if (curPage == 1) {
        alert("Bạn đang ở trang đầu tiên");
    }
    else {
        curPage = curPage - 1;
        getDataPage(curPage);
    }
}

function goNext() {
    if (curPage == totPage) {
        alert("Bạn đang ở trang cuối cùng");
    }
    else {
        curPage = curPage + 1;
        getDataPage(curPage);
    }
}

function getDataPage(page) {
    var filter = {
        Page: page,
        Size: 5,
    };
    var str = JSON.stringify(filter);
    $.ajax({
        type: "POST",
        url: "/Song?handler=List",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { filter: str },
        dataType: "JSON",
        success: function (res) {
            console.log(res);
            if (res.success === true || res.success == true) {
                console.log(res.data);
                var data = res.data;
                dataSong = data.data;
                totPage = data.totalPage;
                $("#tbodySong").html("");
                $("#songTemplate").tmpl(dataSong).appendTo("#tbodySong");
                $("#spanCurrentPage").text(curPage);
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus, errorThrown);
            alert("Lỗi! Không cập nhật được");
        }
    });
}