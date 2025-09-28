$(document).ready(() => {

    $(".register-form").submit((e) => {
        e.preventDefault();

        const username = $('input[type="text"]').val().trim();
        const email = $('input[type="email"]').val().trim();
        const password = $('input[type="password"]').val().trim();

        if (username == "" || email == "" | password == "") {
            alert("all field required!!");
            return;
        }

        const registerData = { username, email, password };

        $.ajax({
            url: "/Account/Register",
            method: "POST",
            contentType: "application/json",
            data: JSON.stringify(registerData),
            success: (res) => {
                alert("registeration successfully!!");
                console.log(res);
            },
            error: (xhr, status, error) => {
                alert("registeration failed")
                console.log(xhr, status, error);
            }
        })


    })


})