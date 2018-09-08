app.factory("authorService", function ($location, baseCrudService) {
    var baseService = new baseCrudService("Authors");
    var authorService = new baseCrudService("Authors");

    authorService.edit = function (author) {
        return baseService.edit(author).then(function (response) {
            $location.path("/authors");
        });
    }

    return authorService;
});