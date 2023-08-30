function LoadCities(stateDropdownCtrl, idState) {
    var selectedState = stateDropdownCtrl.value;
    var cityCtrl = document.getElementById('idCity');
    ClearCities(cityCtrl);
    if (selectedState === 'TS') {
        
        if (cityCtrl != undefined) {
            //add options to the contrl
            var option = document.createElement("option");
            option.text = "HYD";
            option.value = "HYD";
            cityCtrl.add(option);

            option = document.createElement("option");
            option.text = "KMM";
            option.value = "KMM";
            cityCtrl.add(option);

            option = document.createElement("option");
            option.text = "WGL";
            option.value = "WGL";
            cityCtrl.add(option);

            option = document.createElement("option");
            option.text = "KN";
            option.value = "KN";
            cityCtrl.add(option);
        }
    }
}

function ClearCities(cityCtrl){   
    for (i = cityCtrl.options.length - 1; i >= 0; i--) {
        cityCtrl.remove(i);
    }
}