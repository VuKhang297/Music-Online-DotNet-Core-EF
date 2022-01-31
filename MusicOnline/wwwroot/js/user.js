// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openUserModal(id) {
    $('#divModal').modal('show');
    $('#spanId').text(id);
    var item = null;
    for (var i = 0; i < dataUser.length; i++) {
        item = dataUser[i];
        if (item.id == id) {
            console.log(item);
            break;
        }
    }
    $('#txtUserName').val(item.name);
}

function login() {
    console.log("asd");
    var item = {};
    item.username = $('#txtUsername').val();
    item.password = $('#txtPassword').val();
    console.log(item);
    var str = JSON.stringify(item);
    $.ajax({
        type: "POST",
        url: "/Login?handler=Login",
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
        },
        data: { user: str },
        dataType: "JSON",
        success: function (res) {
            if (res.success === true || res.success == true) {
                alert("Đăng nhập thành công!");
                window.location.href = "/";
            }
        },
        error: function (jqXHR, textStatus, errorThrown) {
            console.log(textStatus, errorThrown);
            alert("Lỗi! Không đăng nhập được!");
        }
    });
}

function saveUser() {
    if (1>0) {
        //them moi
        var item = {};
        item.username = $('#username').val();
        item.fullname = $('#fullname').val();
        item.password = $('#password').val();
        item.yearofbirth = parseInt($('#yearofbirth').val());
        item.gender = $('#gender').val();
        item.active = 0;
        item.phone = $('#phone').val();
        item.email = $('#email').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/Register?handler=Add",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { user: str },
            dataType: "JSON",
            success: function (res) {
                if (res.success === true || res.success == true) {
                    alert("Thêm mới thành công!");
                    window.location.href = "/Login";
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
        item.name = $('#txtUserName').val();
        var str = JSON.stringify(item);
        $.ajax({
            type: "POST",
            url: "/UserManagement?handler=Update",
            beforeSend: function (xhr) {
                xhr.setRequestHeader("XSRF-TOKEN",
                    $('input:hidden[name="__RequestVerificationToken"]').val());
            },
            data: { user: str },
            dataType: "JSON",
            success: function (res) {
                console.log(res);
                if (res.success === true || res.success == true) {
                    alert("Cập nhật thành công!");
                    $("#trUser_" + item.id + " td:eq(1)").html(item.name);
                    for (var i = 0; i < dataUser.length; i++) {
                        var user = dataUser[i];
                        if (user.id == item.id) {
                            dataUser[i] = item;
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

function deleteUser(id) {
    if (confirm("Bạn chắc chắn xóa người dùng số " + id + " không?") == true) {
        $.ajax({
            type: "POST",
            url: "/UserManagement?handler=Delete",
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
                    $("#trUser_" + id).remove();
                    var i = 0;
                    for (i = 0; i < dataUser.length; i++) {
                        var User = dataUser[i];
                        if (User.id == item.id) {
                            break;
                        }
                    }
                    dataUser.splice(i, 1);
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(textStatus, errorThrown);
                alert("Lỗi! Không xóa được");
            }
        });
    }
}