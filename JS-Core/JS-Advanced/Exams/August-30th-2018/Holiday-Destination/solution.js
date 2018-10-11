function addDestination() {
    let city = $(".inputData:eq(0)").val();
    let country = $(".inputData:eq(1)").val();
    let season = $("#seasons").val();

    if (city && country && season) {

        let destinationList = $("#destinationsList");
        destinationList.append(`<tr><td>${city}, ${country}</td><td>${season.charAt(0).toUpperCase() + season.substr(1)}</td></tr>`);
        $(".inputData:eq(0)").val("");
        $(".inputData:eq(1)").val("");

        let seasonCounter = $(`#${season.toLowerCase()}`);
        let currentSeasonVal = Number(seasonCounter.val());
        seasonCounter.val(++currentSeasonVal)
    }
}
