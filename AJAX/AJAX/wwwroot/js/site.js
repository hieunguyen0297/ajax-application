// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    //this is for when the radio button is selected
    $(".customerRadio").change(() => {
        console.log("selected");
        doCustomerUpdate();
    })

    function doCustomerUpdate(){
        $.ajax({
            type: "POST",
            url: "customer/showoneperson",
            data: $("form").serialize(),
            success: (data) => {
                $("#customerInformationArea").html(data);
                $("#customerInformationArea").css("display", "block");
            }

        });
    }

    //this is done after the form is submit
    $("#selectCustomer").click((e) => {
        e.preventDefault();

        $.ajax({
            type: "POST",
            url: "customer/showoneperson",
            data: $("form").serialize(),
            success: (data) => {
                $("#customerInformationArea").html(data);
                $("#customerInformationArea").css("display", "block");
            }

        });
    })


})