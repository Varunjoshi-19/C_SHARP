$(document).ready(function () {

    $(".login-form").submit(function (e) {

        e.preventDefault();

        const email = $('input[type="email"]').val().trim();
        const password = $('input[type="password"]').val().trim();


        if (email == "" || password == "") {
            alert("email or password required!!");
            return;
        }

        const loginData = {
            email,
            password
        }

        $.ajax({
            url: "/Account/Login",
            method: "POST",
            contentType: "application/json",
            data: JSON.stringify(loginData),
            success: (response) => {
                alert("login successfully!!");
                console.log(response);
            },
            error: (xhr, status, error) => {
                alert("login failed")
                console.log(xhr, status, error);
            }

        })




    })


})

