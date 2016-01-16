RegistrationModule.controller('RegistrationCtrl',['$scope', '$http', function ($scope, $http) {

	var newUserData = $scope.newUserModel = {};

	$scope.sendDataForRegistration = function () {
		$http({
		  method: 'POST',
		  url: '/api/Account/',
		  data: newUserData
		}).then(function successCallback(response) {
		    console.log(response);
		}, function errorCallback(response) {
		    console.log(response);
		});
		console.log(newUserData);
	};
}]);

