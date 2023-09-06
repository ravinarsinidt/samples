function LoadCities(stateDropdownCtrl, idState) {
    var selectedState = stateDropdownCtrl.value;
    var cityCtrl = document.getElementById('idCity');
    ClearCities(cityCtrl);
    let getUrl = "/customer/getCities?cityId=" + selectedState;
    $.get(getUrl, function (data, status) {
        if (cityCtrl != undefined) {
            for (let i = 0; i < data.length; i++) {
                var option = document.createElement("option");
                option.text = data[i];
                option.value = data[i];
                cityCtrl.add(option);
            }
        }
    });
}

function ClearCities(cityCtrl) {
    for (i = cityCtrl.options.length - 1; i >= 0; i--) {
        cityCtrl.remove(i);
    }
}