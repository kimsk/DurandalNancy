define(['durandal/app'], function (app) {
    return {
        viewName: 'Thanks for visiting Durandal & Nancy Web App!',
        description: 'Durandal is a SPA framework done right and Nancy provides a super-duper-happy-path to all interactions, so we have a super-duper-happy SPA web app done right!',
        activate: function () {
            $.getJSON("/api/list", function (data) {
                app.showMessage(data.Message, data.Title, ['Agree']);
            });
        }
    };
});