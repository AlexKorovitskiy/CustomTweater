var postsModel = new Vue({
    el: "#postsVue",
    data: {
        posts: [{content: 'qqq'}]
    },
    methods: {
        createPost: function () {
            debugger;
            window.location.href = domainFronEnd + "/home/CreatePost";
        }
    }
});

$.ajax({
    type: "GET",
    url: "https://localhost:44341/" + "posts"
}).success(function (data) {
    postsModel.posts = data
}).fail(function (data) {
    debugger;
})