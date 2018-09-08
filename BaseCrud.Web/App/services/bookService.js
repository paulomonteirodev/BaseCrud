app.factory("bookService", function ($location, baseCrudService) {
    var baseService = new baseCrudService("Books");
    var bookService = new baseCrudService("Books");

    bookService.edit = function (book) {
        return baseService.edit(book).then(function (response) {
            $location.path("/books");
        });
    }

    return bookService;
});