app.factory("baseCrudService", function ($http) {

    var baseCrudService = function (uri) {
        this.baseURI = '/api/' + uri;
    }

    baseCrudService.prototype.getItems = function () {
        return $http.get(this.baseURI);
    }

    baseCrudService.prototype.getItem = function (id) {
        var uri = `${this.baseURI}/${id}`;

        return $http.get(uri);
    }

    baseCrudService.prototype.create = function (obj) {
        return $http.post(this.baseURI, obj);
    }

    baseCrudService.prototype.edit = function (obj) {
        var uri = `${this.baseURI}/${obj.Id}`;

        return $http.put(uri, obj);
    }

    baseCrudService.prototype.delete = function (id) {
        var url = `${this.baseURI}/${id}`;

        return $http.delete(url);
    }

    return baseCrudService;

});