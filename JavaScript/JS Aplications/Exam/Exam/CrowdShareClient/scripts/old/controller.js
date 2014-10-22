define(['HTTPRequester', 'validationController', 'ui'], function(HttpRequester, ValidationController, UI) {
    var Controller = (function() {
        var Controller = function(resourceUrl) {
            this.resourseUrl = resourceUrl;
            this.refreshTimeMS = 4000;
            this.showLastMessagesCount = 200;
        };

        Controller.prototype.getUsername = function() {
            return sessionStorage.getItem('username');
        };

        Controller.prototype.setUsername = function(username) {
            sessionStorage.setItem('username', username);
        };

        Controller.prototype.destroyUsername = function() {
            sessionStorage.clear();
        };

        Controller.prototype.isLoggedIn = function() {
            return this.getUsername() != null;
        };

        Controller.prototype.loadChatBox = function() {
            var _this = this;

            setInterval(function() {
                _this.updateChatBox();
            }, _this.refreshTimeMS);
        };

        Controller.prototype.updateChatBox = function() {
            var _this = this;
            HttpRequester.getJSON(this.resourseUrl+"post")
                .then(function(data) {
                    var chatBoxHtml = UI.buildChatBox(data, _this.showLastMessagesCount);
                    $('#posts').html(chatBoxHtml)
                });
        };

        Controller.prototype.loadLoginForm = function() {
            $('#wrapper').load('views/login-template.html');
        };

        Controller.prototype.setEventHandler = function() {
            var _this = this,
                $wrapper = $('#controls');

            $wrapper.on('click', '#login', function() {
                var $loginInput = $('#user'),
                    username = $loginInput.val(),
                    isValidUsername = ValidationController.isUsernameCorrect(username);

                if (isValidUsername) {
                    _this.setUsername(username);
                    $loginInput.removeClass('error-validation');
                }
                else {
                    $loginInput.addClass('error-validation');
                }
            });

            $wrapper.on('click', '#logout', function() {
                var exit = confirm("Are you sure you want to end the session?");
                if (exit === true) {
                    _this.destroyUsername();
                }
            });

            $("#chat-window").on('click', '#post', function() {
                var $messageInput = $('#message'),
                    enteredMessage = $messageInput.val().trim(),
                    postBy = _this.getUsername();

                if (enteredMessage) {
                    HttpRequester.postJSON(_this.resourseUrl+"post", {
                        title: postBy,
                        body: enteredMessage
                    })
                        .then(function() {
                            $messageInput.val('');
                            var postHtml = UI.buildMessage(postBy, enteredMessage);
                            $('#posts').prepend(postHtml);
                            $messageInput.removeClass('error-validation');
                        }, function() {
                            $messageInput.addClass('error-validation');
                        })
                }
                else {
                    $messageInput.addClass('error-validation');
                }
            });
        };

        return Controller;
    }());

    return Controller;
});