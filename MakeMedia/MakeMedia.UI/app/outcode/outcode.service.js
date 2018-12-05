(function () {
    'use strict'
    var module = angular.module('MakeMediaApp');

    module.service('FileService', ['$http', '$q', function ($http, $q) {
        function invoke(fileName) {
            var defered = $q.defer();
            //console.log('i am in service');
            $http({
                url: 'http://localhost:42754/api/File/Getfile?filename=' + fileName,
                responseType: 'json',
                method: 'GET'
                //headers: {
                //    'Authorization': 'Basic VGVjaFRlc3RBUEk6dXNlcjI=',
                //    'Accept-Tenant': 'uk',
                //    'Accept-Language': 'en-GB'
                //}
            }).then(function (response) {
                return defered.resolve(response.data || {});
            })

            return defered.promise;
        }

        return {
            invoke: invoke
        }
    }]);

})();