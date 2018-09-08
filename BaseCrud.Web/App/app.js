var app = angular.module("app", ['ngRoute']);

app.config(function ($routeProvider, $locationProvider) {

    $routeProvider
        .when('/',
            {
                templateUrl: '/Templates/Home/index.html'
            })

        // Author
        .when('/authors',
            {
                templateUrl: '/Templates/Author/list.html',
                controller: 'AuthorListCtrl'
            })

        .when('/authors/new',
            {
                templateUrl: '/Templates/Author/create.html',
                controller: 'AuthorCreateCtrl'
            })

        .when('/authors/edit/:id',
            {
                templateUrl: '/Templates/Author/edit.html',
                controller: 'AuthorEditCtrl'
            })

        .when('/authors/view/:id',
            {
                templateUrl: '/Templates/Author/view.html',
                controller: 'AuthorViewCtrl'
            })

        // Books
        .when('/books',
            {
                templateUrl: '/Templates/Book/list.html',
                controller: 'BookListCtrl'
            })

        .when('/books/new',
            {
                templateUrl: '/Templates/Book/create.html',
                controller: 'BookCreateCtrl'
            })

        .when('/books/edit/:id',
            {
                templateUrl: '/Templates/Book/edit.html',
                controller: 'BookEditCtrl'
            })

        .when('/books/view/:id',
            {
                templateUrl: '/Templates/Book/view.html',
                controller: 'BookViewCtrl'
            });

    // enable html5Mode for pushstate ('#'-less URLs)
    $locationProvider.html5Mode(true);
});


