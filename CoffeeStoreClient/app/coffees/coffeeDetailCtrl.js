(function () {
    "use strict";
    angular
        .module("coffeStore")
        .controller("coffeeDetailCtrl",coffeeDetailCtrl);

    function coffeeDetailCtrl($scope, $http, $stateParams) {


            $http.get('http://localhost:65335/api/coffeeStore/' + $stateParams.id )
                .success(function (response) {
                    $scope.coffe = response;
                })
                .error(function (response) {
                    alert('error');
                });
        
    }

}());