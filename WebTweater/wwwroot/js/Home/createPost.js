var createPostModel = new Vue({
    el: '#createPost',
    data: {
        content: ""
    },
    methods: {
        create: function () {
            var post = {
                id: 0,
                content: this.content
            };
            $.ajax({
                url: domainBackEnd + "create_posts",
                contentType: "application/json",
                method: "POST",
                data: JSON.stringify(post)
            }).success(function (data) {
                window.location.href = domainFronEnd + "/Home/Index";
            }).fail(function (data) {
                debugger;
            });
        }
    }
})