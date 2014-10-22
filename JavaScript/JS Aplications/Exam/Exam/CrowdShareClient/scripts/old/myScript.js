define(['httpRequester'], function(HttpRequester) {
    var Chat = (function() {
        var Chat = function(resourceUrl) {
            this.resourseUrl = resourceUrl;
            this.refreshTimeMS = 4000;
            this.showLastMessagesCount = 200;
        };

        Chat.prototype.run = function(){

        };

        return Chat;
    }());

    return Chat;
});