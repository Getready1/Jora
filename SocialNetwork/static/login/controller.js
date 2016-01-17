LoginModule.controller('LoginCtrl', ['$scope', '$http', function ($scope, $http) {

	var userData = $scope.userData = {};

	$scope.logInUser = function () {
		$http({
		  method: 'POST',
		  url: '/api/Account/Login/',
		  data: userData
		}).then(function successCallback(response) {
		    console.log(response);
		}, function errorCallback(response) {
		    console.log(response);
		});
	};
}]);