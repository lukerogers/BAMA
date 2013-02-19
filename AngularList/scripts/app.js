'use strict';

angular.module('listApp', ['listServices', 'taskServices'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.
            when('/lists',
                {
                    templateUrl: 'home/lists',
                    controller: ListCtrl
                }).
            when('/list/:id',
                {
                    templateUrl: 'home/list',
                    controller: TaskCtrl
                }).otherwise({ redirectTo: '/lists' });
    }]);