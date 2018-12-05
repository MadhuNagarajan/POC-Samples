(function () {
    'use strict'

    var module = angular.module('MakeMediaApp');
    module.controller('FileCtrl', ['$scope', 'FileService', function ($scope, FileService) {
        //console.log('I am here'); // For testing
        $scope.fileData;

        $scope.loadFileData = function () {
            $scope.message = '';

            if ($scope.fileName) {
               // console.log('I am abt to call svc');
                FileService.invoke($scope.fileName).then(function (data) {
                    //console.log('scv called');
                    //console.log('success', data); // For testing

                    $scope.fileData = data;

                    if ($scope.fileData.length == 0) {
                        $scope.message = 'No data found for the outcode entered, please enter a valid filename.';
                    }
                })
            } else {
                $scope.message = "Please enter a valid filename";
            }
        };


    }]);
})();