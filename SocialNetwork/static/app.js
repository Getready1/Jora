var MainModule = angular.module('MainModule', [
	'ngRoute',
	'RegistrationModule',
	'LoginModule'
]);

MainModule.config(['$routeProvider', '$locationProvider',
  function($routeProvider, $locationProvider) {
    $routeProvider.
      when('/registration/', {
        templateUrl: '/static/registration/main.html',
        controller: 'RegistrationCtrl'
      }).when('/', {
      	templateUrl: '/static/login/main.html',
        controller: 'LoginCtrl'
      });

     // $locationProvider.html5Mode(true);
}]);
