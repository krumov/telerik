(function () {
    require.config({
        paths: {
            jquery: "libs/jquery-2.1.1.min",
            chai: "libs/chai",
            cryptoJS: "http://crypto-js.googlecode.com/svn/tags/3.1.2/build/rollups/sha1",
            controls:"controls"
        }
    });

    require(["jquery","cryptoJS",], function ($,cryptoJS) {

        displayMessages();

        setInterval(function() {
            displayMessages();
        }, 3000);


        $('#register').on('click',function(){
           var username = $('#user').val();
            var password = $('#password').val();
            console.log(username + '  ' + password);
            regUser(username,password);

        });

        $('#login').on('click',function(){
            var username = $('#user').val();
            var password = $('#password').val();
            console.log(username + '  ' + password);
            login(username,password);

        });

        $('#logout').on('click',function(){
           logout();
        });

        $('#post').on('click',function(){
            var message = $("#message").val();
            var title = $("#title").val();

            post(message,title);
        });

        function displayMessages() {
            $.getJSON("http://localhost:3000/post", undefined, function (result) {
                console.log(result);
                $('#posts').html(' ');
                for (var i = result.length - 1; i >= 0; i--) {
                    var text = result[i].body;
                    var author = result[i].user.username;
                    var title = result[i].title;
                    $('#posts').append('<div>' + author + ': ' + title + '<p>' +'    '+ text + '</p></div>');
                }
            });

        }
        function regUser (username,password){
            var authCode = CryptoJS.SHA1(username+password).toString();
                console.log(authCode);
            var userToReg = {
                username:username,
                authCode: authCode
            };

            $.ajax({
                type: "POST",
                url: "http://localhost:3000/user",
                data: userToReg,
                success: function(){

                },
                dataType: 'json'
            });
        }

        function login (username,password){
            var authCode = CryptoJS.SHA1(username+password).toString();
            console.log(authCode);
            var userToReg = {
                username:username,
                authCode: authCode
            };

            $.ajax({
                type: "POST",
                url: "http://localhost:3000/auth",
                data: userToReg,
                success: function(result){

                    localStorage.setItem("sessionKey",result.sessionKey);

                    $("#nickname").append(result.username);

                    $("#loginStuff").hide();
                },
                dataType: 'json'
            });
        }

        function logout (){

            var sessionKey = localStorage.getItem('sessionKey');

            $.ajax({
                type: "PUT",
                url: "http://localhost:3000/user",
                data: 'true',
                headers:{'X-SessionKey': sessionKey},
                success: function(){

                    localStorage.removeItem("sessionKey");

                    $("#nickname").html(' ');

                    $("#loginStuff").show();
                },
                dataType: 'json'
            });
        }

        function post (message,title){

            var sessionKey = localStorage.getItem('sessionKey');
            var messageToPost ={
                title:title,
                body:message
            }

            $.ajax({
                type: "POST",
                url: "http://localhost:3000/post",
                data: messageToPost,
                headers:{'X-SessionKey': sessionKey},
                success: function(result){
                    displayMessages();                },
                dataType: 'json'
            });
        }




    });

}());
