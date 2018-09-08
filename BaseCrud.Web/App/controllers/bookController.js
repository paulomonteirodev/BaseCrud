app.controller("BookListCtrl", function ($scope, bookService) {

    getBooks = function () {
        bookService.getItems().then(function (response) {
            $scope.listBooks = response.data;
        });
    };

    $scope.deleteBook = function (id) {
        bookService.delete(id).then(function (response) {
            getBooks();
        });
    };

    getBooks();

});

app.controller("BookEditCtrl", function ($scope, $routeParams, bookService, authorService) {

    var id = $routeParams.id;

    $scope.editBook = function (book) {
        bookService.edit(book);
    };

    bookService.getItem(id).then(function (response) {
        $scope.book = response.data;
    });

    authorService.getItems().then(function (response) {
        $scope.listAuthors = response.data;
    });

});

app.controller("BookViewCtrl",function ($scope, $routeParams, bookService) {

    var id = $routeParams.id;

    bookService.getItem(id).then(function (response) {
        $scope.book = response.data;
    });

});

app.controller("BookCreateCtrl", function ($scope, bookService, authorService) {

    $scope.createBook = function (book) {
        bookService.create(book).then(function (response) {
            $scope.book = null;
        });
    };


    authorService.getItems().then(function (response) {
        $scope.listAuthors = response.data;
    });

});
