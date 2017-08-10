(function () {
    "use strict";
    angular
        .module("coffeStore")
        .controller("coffeeMapCtrl", coffeeMapCtrl);

    function coffeeMapCtrl($scope) {
        var map;
        var marker;
        var place;

        getLocation();

        //basic method to use grolocation (root) 
        function getLocation() {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(displayLocation, displayError);
            }
            else {
                alert("Sorry, this browser doesn't support geolocation!");
            }
        }

        function displayLocation() {
            var googleLatLong = new google.maps.LatLng(38.205027,  -85.763640);
            //display settings for the map
            var mapOptions = {
                zoom: 15,
                center: googleLatLong,
                mapTypeId: google.maps.MapTypeId.ROADMAP
            };

            //load the div in the html page 
            //create the googlr maps
            var mapDiv = document.getElementById("map");
            map = new google.maps.Map(mapDiv, mapOptions);

            marker = new google.maps.Marker({
                map: map,
                position: new google.maps.LatLng(38.205027, -85.763640 ),
                title: "The Coffee Store"
            });

            var infoWindow = new google.maps.InfoWindow();
            marker.content = '<div class="infoWindowContent">' + "best place to drink coffee in Louisville" + '</div>';
            infoWindow.setContent('<h4>' + marker.title + '</h4>' + '<h4>' + "3103 S 3rd St, Louisville, KY 40214" +'</h4>' + marker.content );
            infoWindow.open(map, marker);

            setAutocomplete(map);
        }

        //place the autocomplete search
        function setAutocomplete(map) {
            var input = document.getElementById("search");
            //create google autocomplete
            var autocomplete = new google.maps.places.Autocomplete(input, { types: ['geocode'] });
            //event place changed 
            autocomplete.addListener('place_changed', function () {
                place = autocomplete.getPlace();

                //if you type a wrong place ,the place don't exist diplay a message
                if (!place.geometry) {
                    alert("The place you are looking for is not available or make sure you typed a valid location");
                }
                //else {    }
            });        
        }


        //handle all the possible errors when you are trying to load the map
        function displayError(error) {
            var errors = ["Unknown error", "Permission denied by user", "Position not available", "Timeout error"];
            var message = errors[error.code];
            console.warn("Error in getting your location: " + message, error.message);
        }

        $scope.drawRoute = function () {
            displayLocation();
            var directionsService = new google.maps.DirectionsService;
            var directionsDisplay = new google.maps.DirectionsRenderer;
            directionsDisplay.setMap(map);

            calculateAndDisplayRoute(directionsService, directionsDisplay);


        }

        function calculateAndDisplayRoute(directionsService, directionsDisplay) {
            directionsService.route({
                origin: place.geometry.location,
                destination: marker.position,
                travelMode: 'DRIVING'
            }, function (response, status) {
                if (status === 'OK') {
                    directionsDisplay.setDirections(response);
                } else {
                    window.alert('Directions request failed due to ' + status);
                }
            });
        }

    }}());