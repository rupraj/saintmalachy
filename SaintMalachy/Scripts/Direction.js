var map;
var directionsDisplay;
var directionService;
var markers = [];

function initMap() {
    directionsDisplay = new google.maps.DirectionsRenderer();
    var latlng = new google.maps.LatLng(42.505542, -71.218819);
    var mapOptions = {
        zoom: 18,
        center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    map = new google.maps.Map(document.getElementById('map'), mapOptions);
    var marker = new google.maps.Marker
    (
        {
            position: new google.maps.LatLng(42.505542, -71.218819),
            map: map,
            title: 'St.Malachy'
        }
    );
    markers.push(marker);
    directionsDisplay.setMap(map);
    directionsDisplay.setPanel(document.getElementById('directionsPanel'));
}

function calcRoute() {
    var start = document.getElementById('fromAddress').value;
    var end = '99 bedford st, Burlington, MA 01803';
    var request = {
        origin: start,
        destination: end,
        travelMode: google.maps.DirectionsTravelMode.DRIVING
    };
    directionService = new google.maps.DirectionsService();
    directionService.route(request, function (response, status) {
        if (status == google.maps.DirectionsStatus.OK) {
            directionsDisplay.setDirections(response);
        }
    });
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(null);
    }
}

$("#btnDirections").on("click", calcRoute);