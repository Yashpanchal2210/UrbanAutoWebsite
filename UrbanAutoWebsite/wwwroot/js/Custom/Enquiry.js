$(document).ready(function () {


    $("#btnSubmit").click(function (event) {
        event.preventDefault();
        var isValidForm = true;

        var FirstName = $("#FirstName").val();
        var LastName = $("#LastName").val();
        var Email = $("#Email").val();
        var Phone = $("#Phone").val();
        var State = $("#State").val();
        var City = $("#City").val();
        var Description = $("#Description").val();

        if (FirstName === '') {
            $('.clsFName').text("First Name is required.");
            isValidForm = false;
        } else {
            $('.clsFName').text("");
        }

        if (LastName === '') {
            $('.clsLName').text("Last Name is required.");
            isValidForm = false;
        } else {
            $('.clsLName').text("");
        }

        if (Email === '') {
            $('.clsEmail').text("Email is required.");
            isValidForm = false;
        } else if (!isValidEmail(Email)) {
            $('.clsEmail').text("Email is not valid.");
            isValidForm = false;
        } else {
            $('.clsEmail').text("");
        }

        if (Phone === '') {
            $('.clsPhone').text("Number is required.");
            isValidForm = false;
        }
        else if (Phone.length < 10 || Phone.length > 10) {
            $('.clsPhone').text("Number is not valid.");
            isValidForm = false;
        }
        else {
            $('.clsPhone').text("");
        }

        if (State === '') {
            $('.clsState').text("State is required.");
            isValidForm = false;
        } else {
            $('.clsState').text("");
        }

        if (City === '' || City === null) {
            $('.clsCity').text("City is required.");
            isValidForm = false;
        } else {
            $('.clsCity').text("");
        }

        if (Description === '') {
            $('.clsDescription').text("Message is required.");
            isValidForm = false;
        }
        else if (Description.length < 15) {
            $('.clsDescription').text("Message length should be more than 15 characters.");
            isValidForm = false;
        }
        else {
            $('.clsDescription').text("");
        }

        if (isValidForm) {
            $("#EnquiryForm").submit();
            return true;
        } else {
            event.preventDefault(); // Prevent the form from submitting
        }


    });
});

function isValidEmail(email) {
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}