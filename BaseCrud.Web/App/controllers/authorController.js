app.controller("AuthorListCtrl", function ($scope, authorService) {

    var getAuthors = function () {
        authorService.getItems().then(function (response) {
            $scope.listAuthors = response.data;
        });
    };

    $scope.deleteAuthor = function (id) {
        authorService.delete(id).then(function (response) {
            getAuthors();
        });
    };

    getAuthors();
});

app.controller("AuthorEditCtrl", function ($scope, $routeParams, authorService) {
    var id = $routeParams.id;

    authorService.getItem(id).then(function (response) {
        $scope.author = response.data;
    })

    $scope.editAuthor = function (author) {
        authorService.edit(author);
    };
});

app.controller("AuthorViewCtrl", function ($scope, $routeParams, authorService) {
    var id = $routeParams.id;

    authorService.getItem(id).then(function (response) {
        $scope.author = response.data;
    })
});

app.controller("AuthorCreateCtrl", function ($scope, authorService) {

    $scope.createAuthor = function (author) {
        authorService.create(author).then(function (response) {
            $scope.author = null;
        });
    }

});
