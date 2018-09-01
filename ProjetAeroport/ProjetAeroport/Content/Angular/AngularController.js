app.controller('VolController', function ($scope, VolService){
    function getVolList() {
        VolService.getVol().then(function (vol) {
            $scope.ListeVol = vol.data
            alert("scoped");
        }, function (error) {
            alert('shit that didnt work like expected');
        
        })
    }
});