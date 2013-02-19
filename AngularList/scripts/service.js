'use strict';

/* Services */

angular.module('listServices', ['ngResource']).factory('Lists', function ($resource) {
    return $resource('/api/list/:id', {}, {
        query: {
            method: 'GET',
            isArray: true
        },
        add: { method: 'POST' }
    });
});

angular.module('taskServices', ['ngResource']).factory('Tasks', function ($resource, $routeParams) {
    return $resource('/api/task/:id', { id: $routeParams.id }, {
        add: { method: 'POST' },
        complete: { method: 'PUT' }
    });
});