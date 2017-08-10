(function () {
    "use strict";

    var app = angular.module("coffeStore",
                            ["ui.router"]);

    app.config(["$stateProvider", "$urlRouterProvider",function ($stateProvider, $urlRouterProvider) {

        $urlRouterProvider.otherwise("/"); 
        
        $stateProvider
            .state("home", {
                url: "/",
                templateUrl: "/app/home.html"
            })

            .state("map", {
                url: "/map",
                templateUrl: "/app/map/map.html",
                controller:"coffeeMapCtrl"
            })

            .state("details", {
                url: "/details/:id",
                templateUrl: "/app/coffees/coffeeDetailView.html",
                controller: "coffeeDetailCtrl"
               
            })

            .state("contact", {
                url: "/contact",
                templateUrl: "/app/contact.html"
            })            

            .state("coffeeList", {
                url: "/coffeemenu",
                templateUrl: "/app/coffees/coffeeListView.html",
                controller: "coffeeListCtrl"
            });  

    }]);

}());