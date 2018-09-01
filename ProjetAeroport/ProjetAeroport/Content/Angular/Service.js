app.service('VolService', function ($http) {
    this.getVol = function () {
        return $http.get('/Home/Entrant');
    }
});