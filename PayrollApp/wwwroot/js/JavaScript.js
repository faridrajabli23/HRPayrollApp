$(document).ready(function () {

    
    $("#salary option").remove();
    $("#companies option").remove();
    $("#branch option").remove();
    $("#position option").remove();
    $("#salary option").remove();

    var valueDep = $("#departments").val();
    $.ajax({
        url: "FillCompanies?id=" + valueDep,
        type: "post",
        dataType: "json",
        success: function (response) {
            if (response.status == 200) {
                for (var i = 0; i < response.data.length; i++) {
                    var option = `<option value="${response.data[i].id}">${response.data[i].name}</option>`
                    $("#companies").append(option);
                }
                var valueCom = $("#companies").val();
                $.ajax({
                    url: "FillBranch?id=" + valueCom,
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
                $.ajax({
                    url: "FillPosition?id=" + valueCom,
                    type: "post",
                    dataType: "json",
                    success: function (response) {
                        if (response.status == 200) {
                            for (var i = 0; i < response.data.length; i++) {
                                var option = `<option value="${response.data[i].id}">${response.data[i].name}</option>`
                                $("#position").append(option);
                            }
                            var valuePos = $("#position").val();
                            $.ajax({
                                url: "FillSalary?id=" + valuePos,
                                type: "post",
                                dataType: "json",
                                success: function (response) {
                                    if (response.status == 200) {
                                        var option = `<option>${response.data}</option>`
                                        $("#salary").append(option);
                                    }
                                    else {
                                        $("salary_error_message").text(response.message);
                                    }
                                }
                            })
                        }
                        else {
                            $("position_error_message").text(response.message);
                        }
                    }
                })
            }
            else {
                $("companies_error_message").text(response.message);
            }
        }
    })
    
    



    $("#departments").change(function () {

        $("#salary option").remove();
        $("#companies option").remove();
        $("#branch option").remove();
        $("#position option").remove();
        $("#salary option").remove();

        var value = $(this).val();

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
                    var valueComp = $("#companies").val();
                    $.ajax({
                        url: "FillBranch?id=" + valueComp,
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
                    $.ajax({
                        url: "FillPosition?id=" + valueComp,
                        type: "post",
                        dataType: "json",
                        success: function (response) {
                            if (response.status == 200) {
                                for (var i = 0; i < response.data.length; i++) {
                                    var option = `<option value="${response.data[i].id}">${response.data[i].name}</option>`
                                    $("#position").append(option);
                                }
                                var valuePosi = $("#position").val();
                                $.ajax({
                                    url: "FillSalary?id=" + valuePosi,
                                    type: "post",
                                    dataType: "json",
                                    success: function (response) {
                                        if (response.status == 200) {
                                            var option = `<option>${response.data}</option>`
                                            $("#salary").append(option);
                                        }
                                        else {
                                            $("salary_error_message").text(response.message);
                                        }
                                    }
                                })
                            }
                            else {
                                $("position_error_message").text(response.message);
                            }
                        }
                    })
                }
                else {
                    $("companies_error_message").text(response.message);
                }
            }
        })
        
        
    })
    $("#companies").change(function () {

        $("#branch option").remove();
        $("#position option").remove();
        $("#salary option").remove();

        var value = $(this).val();

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

        $.ajax({
            url: "FillPosition?id=" + value,
            type: "post",
            dataType: "json",
            success: function (response) {
                if (response.status == 200) {
                    for (var i = 0; i < response.data.length; i++) {
                        var option = `<option value="${response.data[i].id}">${response.data[i].name}</option>`
                        $("#position").append(option);
                    }
                    var valuePosit = $("#position").val();
                    $.ajax({
                        url: "FillSalary?id=" + valuePosit,
                        type: "post",
                        dataType: "json",
                        success: function (response) {
                            if (response.status == 200) {
                                var option = `<option>${response.data}</option>`
                                $("#salary").append(option);
                            }
                            else {
                                $("salary_error_message").text(response.message);
                            }
                        }
                    })
                }
                else {
                    $("position_error_message").text(response.message);
                }
            }
        })
        
    })
    $("#position").change(function () {

        var value = $(this).val();

        $("#salary option").remove();

        $.ajax({
            url: "FillSalary?id=" + value,
            type: "post",
            dataType: "json",
            success: function (response) {
                if (response.status == 200) {
                    var option = `<option>${response.data}</option>`
                    $("#salary").append(option);
                }
                else {
                    $("salary_error_message").text(response.message);
                }
            }
        })
    })
})
var Save = function () {
    var arrItem = [];
    var commaSeparatedIds = "";

    $("#payment table td input[type=checkbox]").each(function (index, val) {
        var checkId = $(val).attr("Id");

        var arr = checkId.split("_");

        var currentCheckboxId = arr[1];

        var Ischecked = $("#" + checkId).is(":checked", true);

        if (Ischecked) {
            arrItem.push(currentCheckboxId);
        }

        if (arrItem.length != 0) {
            commaSeparatedIds = arrItem.toString();
            var a = `<a id="toPay" style="margin-left:10px" href="/hrpayroll/payrollspecialist/employeepayment?id=${commaSeparatedIds}" class="btn btn-warning">Yes</a>`;
            var b = `<a id="noToPay" style="margin-left:10px" onclick="DeleteButton()"  class="btn btn-danger">No</a>`;
            $("#toPay").remove();
            $("#noToPay").remove();
            $("#payment").append(a);
            $("#payment").append(b);
            //$.ajax({
            //    url: "EmployeePayment?id=" + commaSeparatedIds,
            //    type: "GET"
            //})
        }
    })

}
var asd = function () {
    var employeeSearchInput = document.getElementById('employeeSearch').value;
    $.ajax({
        url: "FindEmployee?id=" + employeeSearchInput,
        type: "post",
        dataType: "json",
        success: function (response) {
            if (response.status == 200) {
                window.location = "/hrpayroll/employee/details?id=" + response.data;
            }
            else {
                $("branch_error_message").text(response.message);
            }
        }
    })
}
var asdFunc = function () {
    var employeeSearchInput = document.getElementById('employeeSearch').value;
    $.ajax({
        url: "FindEmployee?id=" + employeeSearchInput,
        type: "post",
        dataType: "json",
        success: function (response) {
            if (response.status == 200) {
                window.location = "/hrpayroll/payrollspecialist/employeedetails?id=" + response.data;
            }
            else {
                $("branch_error_message").text(response.message);
            }
        }
    })
}
var employeeSearcher = function () {
    var employeeSearchInput = document.getElementById('userSearch').value;
    $.ajax({
        url: "FindEmployee?id=" + employeeSearchInput,
        type: "post",
        dataType: "json",
        success: function (response) {
            if (response.status == 200) {
                window.location = "/hrpayroll/admin/employeedetails?id=" + response.data;
            }
            else {
                $("branch_error_message").text(response.message);
            }
        }
    })
}

var DeleteButton = function () {
    $("#toPay").remove();
    $("#noToPay").remove();
}
