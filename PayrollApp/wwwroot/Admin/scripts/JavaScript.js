$(document).ready(function () {
    $("#departments").change(function () {
        console.log("fghjk");
        var value = $(this).val();
        $("#companies option").remove();

        $.ajax({
            url: "FillCompanies?id=" + value,
            type: "post",
            dataType: "json",
            success: function (response) {
                if (response.status == 200) {
                    for (var i = 0; i < response.data.length; i++) {
                        var option = `<option value="${response.data[i].id}">${response.data[i].name}</option>`
                        $("#companies").append(option);
                    }
                }
                else {
                    $("companies_error_message").text(response.message);
                }
            }
        })
    })
    $("#companies").change(function () {
        var value = $(this).val();
        console.log("asd");
        $("#branch option").remove();

        $.ajax({
            url: "FillBranch?id=" + value,
            type: "post",
            dataType: "json",
            success: function (response) {
                if (response.status == 200) {
                    for (var i = 0; i < response.data.length; i++) {
                        var option = `<option value="${response.data[i].id}">${response.data[i].name}</option>`
                        $("#branch").append(option);
                    }
                }
                else {
                    $("branch_error_message").text(response.message);
                }
            }
        })
    })
})