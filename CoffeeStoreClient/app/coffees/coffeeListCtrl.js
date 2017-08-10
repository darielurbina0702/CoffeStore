(function () {
    "use strict";
    angular
        .module("coffeStore")
        .controller("coffeeListCtrl",        
            coffeeListCtrl);

    function coffeeListCtrl($scope, $http) {        
        $http.get('http://localhost:65335/api/coffeeStore')
            .success(function (response) {
                $scope.coffeeList = response;
            })
            .error(function (response) {
                alert('error');
            });   
    }

}());